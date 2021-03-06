﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EMS.CustomValidators
{
    public class PhoneLengthAttribute : ValidationAttribute
    {
        private int _minValue { get;  set; }
        public PhoneLengthAttribute(int minValue)
        {

            _minValue = minValue;

            ErrorMessage = "Please check your number";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (value != null)
            {
                int objectLength = Convert.ToString(value).Length;
                if (objectLength != _minValue)
                {
                    return new ValidationResult(this.ErrorMessage);
                }
            }
            return ValidationResult.Success;
        }

    }
}