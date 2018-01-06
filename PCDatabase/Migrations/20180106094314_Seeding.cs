using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PCDatabase.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories (NameCategory, NameFileIcon, DescriptionCategory) VALUES ('Asp.Net', 'asp.png', 'Programowanie web aplikacji.')");
            migrationBuilder.Sql("INSERT INTO Categories (NameCategory, NameFileIcon, DescriptionCategory) VALUES ('Javascript', 'javascript.png', 'Skryptowy język.')");
            migrationBuilder.Sql("INSERT INTO Categories (NameCategory, NameFileIcon, DescriptionCategory) VALUES ('jQuery', 'jquery.png', 'Lekka biblioteka.')");
            migrationBuilder.Sql("INSERT INTO Categories (NameCategory, NameFileIcon, DescriptionCategory) VALUES ('Html5', 'html.png', 'Język wykorzystywany do przedstawiania zawartości strony.')");
            migrationBuilder.Sql("INSERT INTO Categories (NameCategory, NameFileIcon, DescriptionCategory) VALUES ('Css3', 'css.png', 'Język służący do stylowania.')");
            migrationBuilder.Sql("INSERT INTO Categories (NameCategory, NameFileIcon, DescriptionCategory) VALUES ('Xml', 'xml.png', 'Uniwersalny język.')");
            migrationBuilder.Sql("INSERT INTO Categories (NameCategory, NameFileIcon, DescriptionCategory) VALUES ('C#', 'csharp.png', 'Obiektowy język.')");

            migrationBuilder.Sql("INSERT INTO Courses (AuthorCourse, TitleCourse, CategoryId, PriceCourse, Hidden, Bestseller, NameFileImage, DateAdded, DescriptionCourse) VALUES ('Tomek Kowal', 'Asp.Net Mvc', 1, 99, 0, 1, 'obrazekmvc.png', '2018-01-04 11:36:16', 'platforma aplikacyjna do budowy aplikacji internetowych opartych na wzorcu Model-View-Controller (MVC) oparta na technologii ASP.NET.')");
            migrationBuilder.Sql("INSERT INTO Courses (AuthorCourse, TitleCourse, CategoryId, PriceCourse, Hidden, Bestseller, NameFileImage, DateAdded, DescriptionCourse) VALUES ('Jacek Klej', 'Asp.Net', 1, 120, 0, 1, 'obrazekaspnet.png', '2018-01-04 11:36:16', 'zbiór technologii opartych na frameworku zaprojektowanym przez firmę Microsoft. Przeznaczony jest do budowy różnorodnych aplikacji internetowych, a także aplikacji typu XML Web Services.')");
            migrationBuilder.Sql("INSERT INTO Courses (AuthorCourse, TitleCourse, CategoryId, PriceCourse, Hidden, Bestseller, NameFileImage, DateAdded, DescriptionCourse) VALUES ('Irek Macał', 'Asp.Net Mvc - Shortcut', 1, 120, 0, 0, 'obrazekmvc2.png', '2018-01-04 11:36:16', 'Kurs ASP.NET MVC - skrót.')");
            migrationBuilder.Sql("INSERT INTO Courses (AuthorCourse, TitleCourse, CategoryId, PriceCourse, Hidden, Bestseller, NameFileImage, DateAdded, DescriptionCourse) VALUES ('Romek Wisz', 'Javascript', 2, 140, 0, 1, 'obrazekjavascript.png', '2018-01-04 11:36:16', 'Javascrypt - skryptowy język programowania, stworzony przez firmę Netscape, najczęściej stosowany na stronach internetowych. Twórcą JavaScriptu jest Brendan Eich. Pod koniec lat 90. XX wieku organizacja ECMA wydała na podstawie JavaScriptu standard języka skryptowego o nazwie ECMAScript, aktualnie rozwijaniem tego standardu zajmuje się komisja TC39.')");
            migrationBuilder.Sql("INSERT INTO Courses (AuthorCourse, TitleCourse, CategoryId, PriceCourse, Hidden, Bestseller, NameFileImage, DateAdded, DescriptionCourse) VALUES ('Edyta Kruk', 'jQuery', 3, 140, 0, 1, 'obrazekjquery.png', '2018-01-04 11:36:16', 'Kurs jQuery - Framework javascript - owy.')");
            migrationBuilder.Sql("INSERT INTO Courses (AuthorCourse, TitleCourse, CategoryId, PriceCourse, Hidden, Bestseller, NameFileImage, DateAdded, DescriptionCourse) VALUES ('Izolda Ptak', 'Html5', 4, 140, 0, 1, 'obrazekhtml.png', '2018-01-04 11:36:16', 'Kurs HTML5 - składnia.')");
            migrationBuilder.Sql("INSERT INTO Courses (AuthorCourse, TitleCourse, CategoryId, PriceCourse, Hidden, Bestseller, NameFileImage, DateAdded, DescriptionCourse) VALUES ('Stefan Żeromski', 'Css3', 5, 140, 0, 1, 'obrazekcss.png', '2018-01-04 11:36:16', 'Kurs CSS - język stylowy.')");
            migrationBuilder.Sql("INSERT INTO Courses (AuthorCourse, TitleCourse, CategoryId, PriceCourse, Hidden, Bestseller, NameFileImage, DateAdded, DescriptionCourse) VALUES ('Mariusz Nowak', 'Xml', 6, 140, 0, 0, 'obrazekxml.png', '2018-01-04 11:36:16', 'Kurs Xml - język uniwersalny.')");
            migrationBuilder.Sql("INSERT INTO Courses (AuthorCourse, TitleCourse, CategoryId, PriceCourse, Hidden, Bestseller, NameFileImage, DateAdded, DescriptionCourse) VALUES ('Rafał Krupa', 'C#', 7, 140, 0, 1, 'obrazekcsharp.png', '2018-01-04 11:36:16', 'Kurs C# - Poziom Zaawansowany.')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories");
            migrationBuilder.Sql("DELETE FROM Courses");
        }
    }
}
