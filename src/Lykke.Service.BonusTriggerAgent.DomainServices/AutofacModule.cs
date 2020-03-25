﻿using Autofac;
using Lykke.Common;

namespace Lykke.Service.BonusTriggerAgent.DomainServices
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BonusTypePublisher>()
                .As<IStartStop>()
                .SingleInstance();
        }
    }
}
