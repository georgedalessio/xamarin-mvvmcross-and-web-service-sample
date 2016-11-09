﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Rest;
using Newtonsoft.Json.Linq;
using XamMvvmAndWebServices.Models;

namespace XamMvvmAndWebServices.Models
{
    public partial class Course
    {
        private int? _courseID;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? CourseID
        {
            get { return this._courseID; }
            set { this._courseID = value; }
        }
        
        private int? _credits;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? Credits
        {
            get { return this._credits; }
            set { this._credits = value; }
        }
        
        private IList<Enrollment> _enrollments;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<Enrollment> Enrollments
        {
            get { return this._enrollments; }
            set { this._enrollments = value; }
        }
        
        private string _title;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Course class.
        /// </summary>
        public Course()
        {
            this.Enrollments = new LazyList<Enrollment>();
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken courseIDValue = inputObject["CourseID"];
                if (courseIDValue != null && courseIDValue.Type != JTokenType.Null)
                {
                    this.CourseID = ((int)courseIDValue);
                }
                JToken creditsValue = inputObject["Credits"];
                if (creditsValue != null && creditsValue.Type != JTokenType.Null)
                {
                    this.Credits = ((int)creditsValue);
                }
                JToken enrollmentsSequence = ((JToken)inputObject["Enrollments"]);
                if (enrollmentsSequence != null && enrollmentsSequence.Type != JTokenType.Null)
                {
                    foreach (JToken enrollmentsValue in ((JArray)enrollmentsSequence))
                    {
                        Enrollment enrollment = new Enrollment();
                        enrollment.DeserializeJson(enrollmentsValue);
                        this.Enrollments.Add(enrollment);
                    }
                }
                JToken titleValue = inputObject["Title"];
                if (titleValue != null && titleValue.Type != JTokenType.Null)
                {
                    this.Title = ((string)titleValue);
                }
            }
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type Course
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.CourseID != null)
            {
                outputObject["CourseID"] = this.CourseID.Value;
            }
            if (this.Credits != null)
            {
                outputObject["Credits"] = this.Credits.Value;
            }
            JArray enrollmentsSequence = null;
            if (this.Enrollments != null)
            {
                if (this.Enrollments is ILazyCollection<Enrollment> == false || ((ILazyCollection<Enrollment>)this.Enrollments).IsInitialized)
                {
                    enrollmentsSequence = new JArray();
                    outputObject["Enrollments"] = enrollmentsSequence;
                    foreach (Enrollment enrollmentsItem in this.Enrollments)
                    {
                        if (enrollmentsItem != null)
                        {
                            enrollmentsSequence.Add(enrollmentsItem.SerializeJson(null));
                        }
                    }
                }
            }
            if (this.Title != null)
            {
                outputObject["Title"] = this.Title;
            }
            return outputObject;
        }
    }
}
