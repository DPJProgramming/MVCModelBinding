using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace MVC_ModelBinding.Models {
	public class Movie {

		/// <summary>
		/// The movie title
		/// </summary>
		[Required(ErrorMessage = "Title Required")]
		[Display(Name="title")]
		public string Title {get; set;}

		/// <summary>
		/// The first and last name of the person who directed the movie
		/// </summary>
		[Required(ErrorMessage = "Who Directed This Movie?")]
		[Display(Name = "director")]
		public string Director { get; set;}

		/// <summary>
		/// the genre the movie falls under (science fiction, horror, ect)
		/// </summary>
		[Required(ErrorMessage = "Choose a genre")]
		[Display(Name = "genre")]
		public string Genre { get; set;}

		/// <summary>
		/// the cost to purchase the movie
		/// </summary>
		public double price { get; set; }

	}
}
