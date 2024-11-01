using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Validation
{
    //bu bir attirubute, bir validator attiribute ve bizde validator type ı isteyecek.
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        //eğer gönderilen attribute tipi bir IValidator değilse hata verecek
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değil");
            }

            _validatorType = validatorType;
        }

        //bu class bir methodinterception
        //buyüzden methodinterceptiondaki virtual methodlardan kullanacak olduklarımızı burada doldurabiliriz.
        //OnBefore kullanacağımız için şuan bunu dolduruyoruz istersek diğerlerini de kullanabiliriz sonra.
        //Yazdığımız ValidationToolu da burada kullanıyoruz, merkezi bir noktada.
        protected override void OnBefore(IInvocation invocation)
        {
            //Bu bir reflection. Reflection çalışma anında bir şeyler gerçekleştirmemizi sağlar. biz çalışma anında validatoru newlemek istiyoruz tipine göre örn(appointmentvalidator).
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            //örn appointmentvalidatorun base type ını(Business.ValidationRules.FluentValidation) ve onun generic çalıştığı veri tipini bul. generic argümanlarından ilkini getirecek zaten ilki veri tipimiz.
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            //validatorun tipine eşit olan parametleri (yani methodlarda verdiğimiz) bulacak
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            //ve tüm o methodları tek tek gezip 
            foreach (var entity in entities)
            {
                //daha önce yazmış olduğumuz validationtool u kullanarak validate et.
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
