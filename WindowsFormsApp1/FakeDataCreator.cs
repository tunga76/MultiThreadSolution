using MultiThread.WinFormsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThread.WinFormsApp
{
    public class FakeDataCreator
    {
        public static IEnumerable<MailModel> GetMails(int number)
        {
            Bogus.Faker<MailModel> faker = new Bogus.Faker<MailModel>()
              .RuleFor(x => x.To, y => y.Internet.Email())
              .RuleFor(x => x.ProviderType, y => MailProviderType.Smtp);
            return faker.Generate(number);
        }
    }
}
