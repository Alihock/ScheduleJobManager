﻿using DataAccess.BLL;
using DataAccess.Entity;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace JobHost.Common
{
    public class HttpJobDetail : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            string jobName = context.JobDetail.Key.Name;
            Task.Factory.StartNew(() =>
            {
                try
                {
                    //CustomJobDetail customJob = CustomJobDetailBLL.CreateInstance().Get(jobId, jobName);

                }
                catch (Exception ex)
                {

                    throw;
                }
            });
        }
    }
}