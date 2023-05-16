using AkademiPlusObserverPattern.DAL;
using System;

namespace AkademiPlusObserverPattern.ObserverPattern
{
    public class CreateWelcomeMessage:IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context=new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            context.welcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Content = "Dergimize abone olduğunuz için teşekkür ederiz, hoş geldiniz."
            });
            context.SaveChanges();
        }
    }
}
