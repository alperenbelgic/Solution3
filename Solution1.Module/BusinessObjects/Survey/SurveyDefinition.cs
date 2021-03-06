﻿using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using Solution1.Module.BusinessObjects.General;
using Solution1.Module.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class SurveyDefinition : IBusinessObject, IXafEntityObject, IObjectSpaceLink, IHaveIsDeletedMember
    {
        [Browsable(false)]
        [Key]
        public int Id { get; set; }

        public string SurveyName { get; set; }

        public bool IsDefault { get; set; }

        public bool AddProductQuestions { get; set; }

        public int SurveySendingDays { get; set; }

        [Browsable(false)]
        public virtual Company Company { get; set; }

        [Browsable(false)]
        public bool IsDeleted { get; set; }

        public virtual List<QuestionDefinition> Questions { get; set; }

        private IObjectSpace objectSpace = null;
        [NotMapped]
        [Browsable(false)]
        public IObjectSpace ObjectSpace
        {
            get
            {
                return objectSpace;
            }
            set
            {
                objectSpace = value;
            }
        }

        public void OnCreated()
        {
            if (this.Questions == null)
            {
                this.Questions = new List<QuestionDefinition>();
            }

            if (this.Company == null)
            {
                this.Company = UserHelper.GetUsersCompany(this.ObjectSpace);
            }
        }

        public void OnSaving()
        {

        }

        public void OnLoaded()
        {

        }
    }
}
