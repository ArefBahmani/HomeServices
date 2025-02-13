using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.RequestEntite.Enums
{
    public enum StatusEnum
    {
        [Display(Name ="در انتظار پیشنهاد متخصصان")]
        WaitingForExperts = 1,
        [Display(Name = "در انتظار تایید مشتری")]
        WatingForCustomer,
        [Display(Name = "تایید شد")]
        Confirmed ,
        [Display(Name = "رد شده")]
        Rejected ,
        [Display(Name = "انجام شده")]
        Done ,
    }
}
