﻿/*   
 *   * Copyright (c) Microsoft Corporation. All rights reserved. Licensed under the MIT license.  
 *   * See LICENSE in the project root for license information.  
 */
using Owin;

namespace EDUGraphAPI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureIdentityAuth(app);
            ConfigureAADAuth(app);
            ConfigureIoC(app);
        }
    }
}
