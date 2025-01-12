﻿using System;

namespace _0_Framework.Application
{
            
    public class OperationResult
    {
        public long EntityId { get; set; }
        public bool IsSuccedded { get; set; }
        public string Message { get; set; }

        public OperationResult()
        {
            IsSuccedded = false;
        }
        public OperationResult Succcedded(long entityId = -1, string message ="عملیات با موفقیت انجام شد")
        {
            EntityId = entityId;
            IsSuccedded = true;
            Message = message;
            return this;
        }

        public OperationResult Failed(string message)
        {
            IsSuccedded = false;
            Message = message;
            return this;
        }

       
    }
}


