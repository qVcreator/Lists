﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Tests.ListArrayTestSources
{
    internal class AddLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList expected = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            LinkedList actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            int value = 7;

            yield return new object[] { actuallist, expected, value };


            expected = new LinkedList(new int[] { 7 });
            actuallist = new LinkedList(new int[] {});
            value = 7;

            yield return new object[] { actuallist, expected, value };


            expected = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, -7 });
            actuallist = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            value = -7;

            yield return new object[] { actuallist, expected, value };
        }
    }
}
