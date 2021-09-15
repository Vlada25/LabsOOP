﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperationLibrary
{
    /// <summary>
    /// Class for doing array operations
    /// </summary>
    public class MyArray : IArrayOperation
    {
        private double[] array;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="array"> Selected array </param>
        public MyArray(double[] array)
        {
            this.array = array;
        }

        /// <summary>
        /// Getting array
        /// </summary>
        /// <returns> Array </returns>
        public double[] GetArray()
        {
            return array;
        }

        /// <summary>
        /// Overloading operator + 
        /// Elements of second array adding to the end of first array
        /// </summary>
        /// <param name="arr1"> First array </param>
        /// <param name="arr2"> Second array </param>
        /// <returns> Summed arrays </returns>
        public static MyArray operator +(MyArray arr1, MyArray arr2)
        {
            return new MyArray(AddArrays(arr1.GetArray(), arr2.GetArray()));
        }

        /// <summary>
        /// Overloading operator *
        /// Each element is multiplied by a given number
        /// </summary>
        /// <param name="arr"> Selected array </param>
        /// <param name="num"> Selected number </param>
        /// <returns> Changed array </returns>
        public static MyArray operator *(MyArray arr, double num)
        {
            return new MyArray(arr.Multiply(num));
        }

        /// <summary>
        /// Overloading operator /
        /// Each element is divided by a given number
        /// </summary>
        /// <param name="arr"> Selected array </param>
        /// <param name="num"> Selected number </param>
        /// <returns> Changed array </returns>
        public static MyArray operator /(MyArray arr, double num)
        {
            return new MyArray(arr.Divide(num));
        }

        /// <summary>
        /// Elements of second array adding to the end of first array
        /// </summary>
        /// <param name="arr1"> First array </param>
        /// <param name="arr2"> Second array </param>
        /// <returns> Summed arrays </returns>
        private static double[] AddArrays(double[] arr1, double[] arr2)
        {
            int commonLen = arr1.Length + arr2.Length;
            double[] newArray = new double[commonLen];

            int index = 0;
            foreach (double val in arr1)
            {
                newArray[index] = val;
                index++;
            }
            foreach (double val in arr2)
            {
                newArray[index] = val;
                index++;
            }

            return newArray;
        }

        /// <summary>
        /// Each element is divided by a given number
        /// </summary>
        /// <param name="number"> Selected number </param>
        /// <returns> Changed array </returns>
        public double[] Divide(double number)
        {
            double[] newArray = new double[GetArray().Length];

            int index = 0;
            foreach (double val in GetArray())
            {
                newArray[index] = val / number;
                index++;
            }

            return newArray;
        }

        /// <summary>
        /// Each element is multiplyed by a given number
        /// </summary>
        /// <param name="number"> Selected number </param>
        /// <returns> Changed array </returns>
        public double[] Multiply(double number)
        {
            double[] newArray = new double[GetArray().Length];

            int index = 0;
            foreach (double val in GetArray())
            {
                newArray[index] = val * number;
                index++;
            }

            return newArray;
        }

        public override string ToString()
        {
            string res = "[ ";

            foreach (double val in array)
            {
                res += val + "; ";
            }

            res += "]";

            return res;
        }
    }
}
