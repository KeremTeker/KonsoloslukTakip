﻿using Entities.Concrete;
using Entities.DTO_s;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAppointmentService
    {
        //List<Appointment> GetAll();
        //IResult olamaz çünkü datayı da döndürmeliyiz.
        //Buyüzden IDataResult oluşturuz IResulttan kalıtım alacak message ve succes döndürecek ve kendisi generic olarak bir data listesi alacak.
        IDataResult<List<Appointment>> GetAll();
        IDataResult<List<Appointment>> GetAllByCategory(int id);
        IDataResult<List<Appointment>> GetAllByStatus(bool status);
        IDataResult<List<AppointmentDetailDto>> GetAppointmentDetails();

        //void yerine IResult döndürüyoruz IResultın içinde isSucces ve Message var.
        IResult Add(Appointment appointment);
        //Appointment GetById(int id);
        IDataResult <Appointment> GetById(int id);
        IResult Update(Appointment appointment);
    }
}
