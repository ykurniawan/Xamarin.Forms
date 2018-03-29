﻿using System;
using System.Collections;
using System.Collections.Generic;

/*
The MIT License(MIT)

Copyright(c) 2017 Alexander Reyes(alexrainman1975 @gmail.com)

Permission is hereby granted, free of charge, to any person obtaining a copy of this software
and associated documentation files (the "Software"), to deal in the Software without restriction,
including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial
portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL
THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
IN THE SOFTWARE.
 */

namespace Xamarin.Forms
{
    internal static class IEnumerableExtensions
    {
        public static object GetItem(this IEnumerable e, int index)
        {
            var enumerator = e.GetEnumerator();
            int i = 0;
            while (enumerator.MoveNext())
            {
                if (i == index)
                    return enumerator.Current;
                i++;
            }
            return null;
        }

        public static int GetCount(this IEnumerable e)
        {
			if (e == null)
				return 0; 
            var enumerator = e.GetEnumerator();
            int i = 0;
            while (enumerator.MoveNext())
            {
                i++;
            }
            return i;
        }

        public static List<object> GetList(this IEnumerable e)
        {
            var enumerator = e.GetEnumerator();
            var list = new List<object>();
            while (enumerator.MoveNext())
            {
                list.Add(enumerator.Current);
            }
            return list;
        }
    }
}
