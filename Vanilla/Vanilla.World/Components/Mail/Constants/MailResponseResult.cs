﻿namespace Vanilla.World.Components.Mail.Constants
{
    public enum MailResponseResult
    {
        MAIL_OK = 0,
        MAIL_ERR_EQUIP_ERROR = 1,
        MAIL_ERR_CANNOT_SEND_TO_SELF = 2,
        MAIL_ERR_NOT_ENOUGH_MONEY = 3,
        MAIL_ERR_RECIPIENT_NOT_FOUND = 4,
        MAIL_ERR_NOT_YOUR_TEAM = 5,
        MAIL_ERR_INTERNAL_ERROR = 6,
        MAIL_ERR_DISABLED_FOR_TRIAL_ACC = 14,
        MAIL_ERR_RECIPIENT_CAP_REACHED = 15,
        MAIL_ERR_CANT_SEND_WRAPPED_COD = 16,
        MAIL_ERR_MAIL_AND_CHAT_SUSPENDED = 17,
        MAIL_ERR_TOO_MANY_ATTACHMENTS = 18,
        MAIL_ERR_MAIL_ATTACHMENT_INVALID = 19,
    };
}
