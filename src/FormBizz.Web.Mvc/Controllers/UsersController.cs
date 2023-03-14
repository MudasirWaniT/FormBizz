﻿using Abp.AspNetCore.Mvc.Authorization;
using FormBizz.Authorization;
using FormBizz.Storage;
using Abp.BackgroundJobs;
using Abp.Authorization;

namespace FormBizz.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}