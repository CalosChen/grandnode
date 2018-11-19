using Autofac;
using Grand.Core.Configuration;
using Grand.Core.Infrastructure;
using Grand.Core.Infrastructure.DependencyManagement;
using Grand.Web.Areas.Admin.Services;

namespace Grand.Web.Areas.Admin.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder, GrandConfig config)
        {
            builder.RegisterType<ActivityLogViewModelService>().As<IActivityLogViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<AddressAttributeViewModelService>().As<IAddressAttributeViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<AffiliateViewModelService>().As<IAffiliateViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<BlogViewModelService>().As<IBlogViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<CampaignViewModelService>().As<ICampaignViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryViewModelService>().As<ICategoryViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<CheckoutAttributeViewModelService>().As<ICheckoutAttributeViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<ContactAttributeViewModelService>().As<IContactAttributeViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<ContactFormViewModelService>().As<IContactFormViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<CountryViewModelService>().As<ICountryViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<CurrencyViewModelService>().As<ICurrencyViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<CustomerActionViewModelService>().As<ICustomerActionViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<CustomerAttributeViewModelService>().As<ICustomerAttributeViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<CustomerViewModelService>().As<ICustomerViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<CustomerReminderViewModelService>().As<ICustomerReminderViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<CustomerRoleViewModelService>().As<ICustomerRoleViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<CustomerTagViewModelService>().As<ICustomerTagViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<DiscountViewModelService>().As<IDiscountViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<EmailAccountViewModelService>().As<IEmailAccountViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<GiftCardViewModelService>().As<IGiftCardViewModelService>().InstancePerLifetimeScope();
            builder.RegisterType<KnowledgebaseViewModelService>().As<IKnowledgebaseViewModelService>().InstancePerLifetimeScope();
        }

        public int Order
        {
            get { return 3; }
        }
    }
}
