using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SpryStore.PresentationLayer.Models
{
	public class CustomIdentityValidator:IdentityErrorDescriber
	{
		public override IdentityError PasswordRequiresLower()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresLower",
				Description = "Lütfen az 1 küçük harf girişi yapınız."
			};
		}
		public override IdentityError PasswordRequiresUpper()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresUpper",
				Description = "Lütfen az 1 büyük harf girişi yapınız."
			};
		}
		public override IdentityError PasswordRequiresDigit()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresDigit",
				Description = "Lütfen az 1 rakam girişi yapınız."
			};
		}
		public override IdentityError PasswordRequiresNonAlphanumeric()
		{
			return new IdentityError()
			{
				Code = "PasswordRequiresNonAlphanumeric",
				Description = "Lütfen az 1 sembol girişi yapınız."
			};
		}
		public override IdentityError PasswordTooShort(int length)
		{
			return new IdentityError()
			{
				Code = "PasswordTooShort",
				Description = "Lütfen en az 8 karakter girişi yapınız."
			};
		}
	}
}
