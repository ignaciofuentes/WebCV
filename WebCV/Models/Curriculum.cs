﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using WebCV.Controllers;

namespace WebCV.Models
{
    [DataContract]
    public class Curriculum
    {
       
        [DataMember(Order = 0)]
        public string Name { get; set; }
        [DataMember(Order = 1)]
        public SerializableDictionary BasicInfoItems { get; set; }
        [DataMember(Order = 2)]
        public IEnumerable<ExperienceItem> ExperienceItems { get; set; }
        [DataMember(Order = 3)]
        public List<EducationItem> EducationItems { get; set; }
        [DataMember(Order = 4)]
        public ParagraphList SkillsParagraphs { get; set; }
        [DataMember(Order=5)]
        public string Gravatar { get; set; }

    }

    
    //These are needed to clean up the xml generated by DataContractSerializer
    [CollectionDataContract
    (
    ItemName = "Item",
    KeyName = "Key",
    ValueName = "Value")]
    public class SerializableDictionary : Dictionary<string, string> { }

    [CollectionDataContract(Name = "Paragraphs", ItemName = "Paragraph")]
    public class ParagraphList : Collection<string> { }
}