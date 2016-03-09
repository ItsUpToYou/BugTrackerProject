using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Joystick.BOL.Core
{
    public class CheckResult
    {
        public CheckResult(object entity)
        {
            if (entity is Exception)
                throw new ArgumentException("entity не трябва да бъде от тип Exception!", "entity");

            this.ObjectInstance = entity;
            this.Details = new List<CheckResultDetail>();
        }

        public CheckResult(object entity, Exception exception)
            : this(entity)
        {
            this.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, string.Empty, exception.ToString()));
        }

        public bool Success
        {
            get
            {
                return !this.Details.Any(s => s.Type == CheckResultDetail.ErrorType.Error);
            }
        }

        public string ErrorProperty
        {
            get
            {
                var det = this.Errors.FirstOrDefault();
                if (det == null)
                    return string.Empty;

                return det.PropertyName;
            }
        }

        public Object ObjectInstance { get; set; }

        public List<CheckResultDetail> Details { get; set; }

        public List<CheckResultDetail> Errors
        {
            get
            {
                return this.Details.Where(d => d.Type == CheckResultDetail.ErrorType.Error).ToList();
            }
        }

        public List<CheckResultDetail> Warnings
        {
            get
            {
                return this.Details.Where(d => d.Type == CheckResultDetail.ErrorType.Warning).ToList();
            }
        }

        public String F_Print(String separator = "\n")
        {
            return String.Join(separator, this.Details.Select(s => s.Message));

        }

        public static CheckResult Default
        {
            get
            {
                return new CheckResult(null);
            }
        }

        public static readonly CheckResult Empty = new CheckResult(null);


        /// <summary>
        /// Добавя нова грешка в списъка
        /// </summary>
        /// <param name="message">Съобщение</param>
        /// <param name="property">Property за което се отнася</param>
        public void AddError(string message, string property)
        {
            this.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Error, property, message));
        }

        /// <summary>
        /// Добавя предупреждение в списъка
        /// </summary>
        /// <param name="message">Съобщение</param>
        /// <param name="property">Property за което се отнася</param>
        public void AddWarning(string message, string property)
        {
            this.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.Warning, property, message));
        }

        /// <summary>
        /// Добавя информация само с флаг "None"
        /// </summary>
        /// <param name="message">Съобщение</param>
        /// <param name="property">Property за което се отнася</param>
        public void AddInfo(string message, string property="")
        {
            this.Details.Add(new CheckResultDetail(CheckResultDetail.ErrorType.None, property, message));
        }

        /// <summary>
        /// Копира детайлите от сорса към дестинацията
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        internal static void CopyDetails(CheckResult source, CheckResult destination)
        {
            destination.Details.AddRange(source.Details);
        }
    }
}
