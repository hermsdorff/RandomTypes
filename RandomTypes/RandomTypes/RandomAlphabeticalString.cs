﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomTypes
{
    public class RandomAlphabeticalString: IRandomType<string>
    {
        RandomString _randomString;
        Random _random = new Random();

        private readonly char[] Alphabet = new[]        
        { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
          'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

        public RandomAlphabeticalString(int minLength, int maxLength)
        {
            _randomString = new RandomString(minLength, maxLength, Alphabet);
        }

        public string GetNext()
        {
            return _randomString.GetNext();
        }
    }
}
