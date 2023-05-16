using AkademiPlusObserverPattern.DAL;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace AkademiPlusObserverPattern.ObserverPattern
{
    public class CreateMagazineAnnouncementObserver : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateMagazineAnnouncementObserver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser Appuser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = Appuser.Name + " " + Appuser.Surname,
                Magazine = "Bilim ve Teknoloji Dergisi",
                Content = "Mayıs sayısı bayimize gelmiştir."
            });
            context.SaveChanges();
        }
    }
}
