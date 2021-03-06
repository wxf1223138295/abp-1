﻿using System;
using System.Collections.Generic;

namespace Volo.Abp.AspNetCore.Mvc.ApplicationConfigurations
{
    [Serializable]
    public class ApplicationLocalizationConfigurationDto
    {
        public Dictionary<string, Dictionary<string, string>> Values { get; set; }

        public ApplicationLocalizationConfigurationDto()
        {
            Values = new Dictionary<string, Dictionary<string, string>>();
        }
    }
}