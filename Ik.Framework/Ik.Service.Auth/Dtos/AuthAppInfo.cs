﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ik.Service.Auth.Dtos
{
    public class AuthAppInfo
    {
        public Guid AppId { get; set; }

        public string AppCode { get; set; }

        public string AppName { get; set; }

        public string AppDesc { get; set; }

        public bool AppIsEnable { get; set; }

        public bool AppIsDelete { get; set; }

        public DateTime AppCreateTime { get; set; }

        public DateTime AppUpdateTime { get; set; }
    }

    public class AuthFunctionInfo : AuthAppInfo
    {
        public Guid FunctionId { get; set; }

        public Guid ParentFunctionId { get; set; }

        public string FuncCode { get; set; }

        public string FuncName { get; set; }

        public string FuncDesc { get; set; }

        public bool FuncIsEnable { get; set; }

        public bool FuncIsDelete { get; set; }

        public DateTime FuncCreateTime { get; set; }

        public DateTime FuncUpdateTime { get; set; }
    }
}
