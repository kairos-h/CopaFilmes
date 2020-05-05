﻿using System;
using System.Collections.Generic;
using System.Linq;
using CopaFilmesAPI;
using CopaFilmesAPI.Domain.Models;
using Xunit;
using FluentAssertions;
using CopaFilmesAPI.Domain.Services;

namespace CopaFilmesAPI.Test
{
    public class MatchUnitTest2 : MovieMatch
    {
        [Fact]
        public void MatchTest()
        {
            // Arrange
            List<Competitors> moviesMock = new List<Competitors>();
            moviesMock.Add(new Competitors { Titulo = "Os Incríveis 2", Nota = 8.5 });
            moviesMock.Add(new Competitors { Titulo = "Jurassic World: Reino Ameaçado", Nota = 6.7 });
            moviesMock.Add(new Competitors { Titulo = "Oito Mulheres e um Segredo", Nota = 6.3 });
            moviesMock.Add(new Competitors { Titulo = "Hereditário", Nota = 7.8 });
            moviesMock.Add(new Competitors { Titulo = "Vingadores: Guerra Infinita", Nota = 8.8 });
            moviesMock.Add(new Competitors { Titulo = "Deadpool 2", Nota = 8.1 });
            moviesMock.Add(new Competitors { Titulo = "Han Solo: Uma História Star Wars", Nota = 7.2 });
            moviesMock.Add(new Competitors { Titulo = "Thor: Ragnarok", Nota = 7.9 });

            var numberOne = new Competitors { Titulo = "Vingadores: Guerra Infinita", Nota = 8.8 };
            var numberTwo = new Competitors { Titulo = "Os Incríveis 2", Nota = 8.5 };
            List<Competitors> resultList = new List<Competitors>();
            resultList.Add(numberOne);
            resultList.Add(numberTwo);

            // Act
            var result = Match(moviesMock);

            // Assert
            resultList.Should().BeEquivalentTo(result);
        }
    }

}
