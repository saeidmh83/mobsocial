using System.Collections;
using System.Collections.Generic;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Customers;
using Nop.Plugin.Widgets.MobSocial.Controllers;
using Nop.Plugin.Widgets.MobSocial.Domain;

namespace Nop.Plugin.Widgets.MobSocial.Core
{
    /// <summary>
    /// Social Network Message service. Used for sending social network notifications.
    /// </summary>
    public interface IMobSocialMessageService
    {
        int SendFriendRequestNotification(Customer customer, int friendRequestCount, int languageId, int storeId);

        int SendEventInvitationNotification(Customer customer, int languageId, int storeId);

        int SendPendingFriendRequestNotification(Customer customer, int friendRequestCount, int languageId, int storeId);

        int SendBirthdayNotification(Customer customer, int languageId, int storeId);

        int SendProductReviewNotification(Customer customer, List<Product> unreviewedProducts, int languageId, int storeId);

        int SendSomeoneSentYouASongNotification(Customer customer, int languageId, int storeId);
    }

}
