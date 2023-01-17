using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace MVC_ModelBinding.Models {
	public class Movie {

		/// <summary>
		/// The movie title
		/// </summary>
		[Required(ErrorMessage = "Title Required")]
		[Display(Name="Movie Title")]
		public string Title {get; set;}

		/// <summary>
		/// The first and last name of the person who directed the movie
		/// </summary>
		[Required(ErrorMessage = "Who Directed This Movie?")]
		[Display(Name = "Director")]
		public string Director { get; set;}

		/// <summary>
		/// the genre the movie falls under (science fiction, horror, ect)
		/// </summary>
		[Required(ErrorMessage = "Choose a genre")]
		[Display(Name = "Genre")]
		public string Genre { get; set;}

		/// <summary>
		/// the cost to purchase the movie
		/// </summary>
		[Range(0.01, 1000, ErrorMessage="Enter a price between .01 to 1000")]
		[Display(Name ="Price")]
		public double Price { get; set; }

	}
}
