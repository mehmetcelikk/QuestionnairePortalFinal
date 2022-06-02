using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT.Abstract;
using Core.Utilities.Security.JWT.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using QuestionnairePortal.Business.Abstract;
using QuestionnairePortal.Business.Concrete;

namespace Business.DependencyResolvers
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>();
            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>();

            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>();

            builder.RegisterType<AuthenticationManager>().As<IAuthenticationService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<QuestionnaireManager>().As<IQuestionnaireService>();
            builder.RegisterType<EfQuestionnaireDal>().As<IQuestionnaireDal>();

            builder.RegisterType<QuestionnaireReplieManager>().As<IQuestionnaireReplieService>();
            builder.RegisterType<EfQuestionnaireReplieDal>().As<IQuestionnaireReplieDal>();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()

                }).SingleInstance();

        }
    }
}
