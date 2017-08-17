﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace LR.ClinicaMedica.UI.Site.Filters
{
    public static class PermissionFilter
    {
        public static MvcHtmlString IfClaimsHelper(this MvcHtmlString value, string claimName, string claimValue)
        {
            return ValidadePermission(claimName, claimValue) ? value : MvcHtmlString.Empty;
        }

        public static bool IfClaim(this WebViewPage page, string claimName, string claimValue)
        {
            return ValidadePermission(claimName, claimValue);
        }

        private static bool ValidadePermission(string claimName,string claimValue)
        {
            var identity = (ClaimsIdentity)HttpContext.Current.User.Identity;

            var claim = identity.Claims.FirstOrDefault(c => c.Type == claimName);

            return claim != null && claim.Value.Contains(claimValue);
        }
    }
}