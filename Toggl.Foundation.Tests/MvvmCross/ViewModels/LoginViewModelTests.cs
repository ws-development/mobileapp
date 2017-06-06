﻿using NSubstitute;
using Toggl.Ultrawave;
using Toggl.Foundation.MvvmCross.ViewModels;
using Toggl.Multivac.Models;
using Microsoft.Reactive.Testing;
using Toggl.Foundation.MvvmCross.Services;

namespace Toggl.Foundation.Tests.MvvmCross.ViewModels
{
    public class LoginViewModelTests
    {
        public abstract class LoginViewModelTest : BaseViewModelTests<LoginViewModel>
        {
            protected const string ValidEmail = "susancalvin@psychohistorian.museum";
            protected const string InvalidEmail = "foo@";

            protected TestScheduler TestScheduler { get; } = new TestScheduler();
            protected IUser User { get; } = new User { Id = 10, ApiToken = "1337" };
            protected IApiFactory ApiFactory { get; } = Substitute.For<IApiFactory>();

            protected override void AdditionalSetup()
            {
                base.AdditionalSetup();

                Ioc.RegisterSingleton(ApiFactory);
            }
        }
    }
}
    