﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Webtina.UI.Models.ViewModels;

namespace Webtina.UI.Services.Services
{
    public interface IPageService
    {
        Task<PageViewModel> Get(string url); 
    }
}
