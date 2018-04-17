﻿using System;
using System.Collections.Generic;

namespace ManagementBots.Db
{
    public partial class Bot
    {
        public Bot()
        {
            BotBlocked = new HashSet<BotBlocked>();
            BotDeleted = new HashSet<BotDeleted>();
            DnsHistory = new HashSet<DnsHistory>();
            ServiceNavigation = new HashSet<Service>();
            WebAppHistory = new HashSet<WebAppHistory>();
            WebHookUrlHistory = new HashSet<WebHookUrlHistory>();
        }

        public int Id { get; set; }
        public string BotName { get; set; }
        public string Token { get; set; }
        public string Text { get; set; }
        public DateTime? CreateTimeStamp { get; set; }
        public int? FollowerId { get; set; }
        public int? WebAppId { get; set; }
        public int? ProxyServeId { get; set; }
        public int? WebHookUrlId { get; set; }
        public int? ServiceId { get; set; }
        public bool Visable { get; set; }
        public bool Deleted { get; set; }
        public bool Blocked { get; set; }
        public bool Launched { get; set; }

        public Follower Follower { get; set; }
        public ProxyServer ProxyServe { get; set; }
        public Service Service { get; set; }
        public WebApp WebApp { get; set; }
        public ReserveWebApp ReserveWebApp { get; set; }
        public ReserveWebHookUrl ReserveWebHookUrl { get; set; }
        public ICollection<BotBlocked> BotBlocked { get; set; }
        public ICollection<BotDeleted> BotDeleted { get; set; }
        public ICollection<DnsHistory> DnsHistory { get; set; }
        public ICollection<Service> ServiceNavigation { get; set; }
        public ICollection<WebAppHistory> WebAppHistory { get; set; }
        public ICollection<WebHookUrlHistory> WebHookUrlHistory { get; set; }
    }
}
