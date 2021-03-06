using NUnit.Framework;
using ListArray.Tests.ListArrayTestSources;
using ListArray.Tests.ListArrayNegativeTestSources;
using System;

namespace ListArray.Test
{
    public class ListArrayTests
    {
        [TestCaseSource(typeof(AddLastTestSource))]
        public void AddLastTest(ListArray actuallist, ListArray expected, int value)
        {
            actuallist.AddLast(value);
            Assert.AreEqual(expected, actuallist);
        }

        [TestCaseSource(typeof(AddFirstTestSource))]
        public void AddFirstTest(ListArray actuallist, ListArray expected, int value)
        {
            actuallist.AddFirst(value);
            Assert.AreEqual(expected, actuallist);
        }


        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(ListArray actuallist, ListArray expected, int value, int index)
        {
            actuallist.AddByIndex(index, value);
            Assert.AreEqual(expected, actuallist);
        }

        [TestCaseSource(typeof(AddByIndexNegativeTestSource))]
        public void AddByIndexTest_WhenIndexOutOfLength_ShouldThrowException(ListArray actuallist, int value, int index)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actuallist.AddByIndex(index, value));
        }

        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(ListArray actuallist, ListArray expected)
        {
            actuallist.DeleteLast();
            Assert.AreEqual(expected, actuallist);
        }

        [TestCaseSource(typeof(DeleteLastNegativeTestSource))]
        public void DeleteLastTest_WhenLengthOfListIsEquaalZero_ShouldThrowException(ListArray actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.DeleteLast());
        }

        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(ListArray actuallist, ListArray expected)
        {
            actuallist.DeleteFirst();
            Assert.AreEqual(expected, actuallist);
        }

        [TestCaseSource(typeof(DeleteFirstNegativeTestSource))]
        public void DeleteFirstTest_WhenLengthOfListIsEquaalZero_ShouldThrowException(ListArray actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.DeleteFirst());
        }

        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(ListArray actuallist, ListArray expected, int index)
        {
            actuallist.DeleteByIndex(index);
            Assert.AreEqual(expected, actuallist);
        }

        [TestCaseSource(typeof(DeleteByIndexTest_WhenLengthOfListIsEquaalZero_ShouldThrowExceptionNegativeTestSource))]
        public void DeleteByIndexTest_WhenLengthOfListIsEquaalZero_ShouldThrowException(int index, ListArray actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.DeleteByIndex(index));
        }

        [TestCaseSource(typeof(DeleteByIndexTest_WhenIndexOutOfLength_ShouldThrowExceptionNegativeTestSource))]
        public void DeleteByIndexTest_WhenIndexOutOfLength_ShouldThrowException(int index, ListArray actuallist)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actuallist.DeleteByIndex(index));
        }

        [TestCaseSource(typeof(DeleteRangeOfLastTestSource))]
        public void DeleteRangeOfLastTest(ListArray actuallist, ListArray expected, int range)
        {
            actuallist.DeleteRangeOfLast(range);
            Assert.AreEqual(expected, actuallist);
        }

        [TestCaseSource(typeof(DeleteRangeOfLastNegativeTestSource_WhenRnageGreaterThanLength))]
        public void DeleteRangeOfLastTest_WhenIndexOutOfLength_ShouldThrowException(int rangeLength, ListArray actuallist)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actuallist.DeleteRangeOfLast(rangeLength));
        }

        [TestCaseSource(typeof(DeleteRangeOfLastNegativeTestSource_WhenRnageLessThanZero))]
        public void DeleteRangeOfLastTest_WhenRnageLessThanZero_ShouldThrowException(int rangeLength, ListArray actuallist)
        {
            Assert.Throws<ArgumentException>(() => actuallist.DeleteRangeOfLast(rangeLength));
        }

        [TestCaseSource(typeof(DeleteRangeOfFirstTestSource))]
        public void DeleteRangeOfFirstTest(ListArray actuallist, ListArray expected, int range)
        {
            actuallist.DeleteRangeOfFirst(range);
            Assert.AreEqual(expected, actuallist);
        }

        [TestCaseSource(typeof(DeleteRangeOfFirstNegativeTestSource_WhenRnageGreaterThanLength))]
        public void DeleteRangeOfFirstTest_WhenIndexOutOfLength_ShouldThrowException(int rangeLength, ListArray actuallist)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actuallist.DeleteRangeOfFirst(rangeLength));
        }

        [TestCaseSource(typeof(DeleteRangeOfFirstNegativeTestSource_WhenRnageLessThanZero))]
        public void DeleteRangeOfFirstTest_WhenRangeLessThanZero_ShouldThrowException(int rangeLength, ListArray actuallist)
        {
            Assert.Throws<ArgumentException>(() => actuallist.DeleteRangeOfFirst(rangeLength));
        }

        [TestCaseSource(typeof(DeleteRangeByIndexTestSourcce))]
        public void DeleteRangeByIndexTest(ListArray actuallist, ListArray expected, int range, int index)
        {
            actuallist.DeleteRangeByIndex(index,range);
            Assert.AreEqual(expected, actuallist);
        }

        [TestCaseSource(typeof(DeleteRangeByIndexNegativeTestSource_WhenIndexOutOfRange))]
        public void DeleteRangeByIndexTest_WhenIndexOutOfRange_ShouldThrowException(int index, int rangeLength, ListArray actuallist)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actuallist.DeleteRangeByIndex(index, rangeLength));
        }

        [TestCaseSource(typeof(DeleteRangeByIndexNegativeTestSource_WhenRangeGreaterThanLength))]
        public void DeleteRangeByIndexTest_WhenRangeGreaterThanLength_ShouldThrowException(int index, int rangeLength, ListArray actuallist)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => actuallist.DeleteRangeByIndex(index, rangeLength));
        }

        [TestCaseSource(typeof(DeleteRangeByIndexNegativeTestSource_WhenRangeLessThanZero))]
        public void DeleteRangeByIndexTest_WhenRangeLessThanZero_ShouldThrowException(int index, int rangeLength, ListArray actuallist)
        {
            Assert.Throws<ArgumentException>(() => actuallist.DeleteRangeByIndex(index, rangeLength));
        }

        [TestCaseSource(typeof(FindIndexByFirstElementTestSource))]
        public void FindIndexByFirstElementTest(ListArray list, int expected, int val)
        {
            int actual = list.FindIndexByFirstElement(val);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(ChangeElementByindexTestSource))]
        public void ChangeElementByindexTest(int index, int value, ListArray actualList, ListArray expected)
        {
            actualList.ChangeElementByindex(index, value);
            Assert.AreEqual(expected, actualList);
        }

        [TestCaseSource(typeof(ChangeElementByindexNegativeTestSource_WhenLengthIsEqualsZero))]
        public void ChangeElementByindexTest_WhenLengthIsEqualsZero_ShouldThrowException(int index, int value, ListArray actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.ChangeElementByindex(index, value));
        }

        [TestCaseSource(typeof(ChangeElementByindexNegativeTestSource_WhenIndexOutOfLength))]
        public void ChangeElementByindexTest_WhenIndexOutOfLength_ShouldThrowException(int index, int value, ListArray actuallist)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actuallist.ChangeElementByindex(index, value));
        }

        [TestCaseSource(typeof(ReverseTestSource))]
        public void ReverseTest(ListArray actualList, ListArray expected)
        {
            actualList.Reverse();
            Assert.AreEqual(expected, actualList);
        }


        [TestCaseSource(typeof(FindMaxTestSource))]
        public void FindMaxTest(ListArray actualList, int expected)
        {
            int actual = actualList.FindMax();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindMinNegativeTestSource_WhenLengthIsEqualsZero))]
        public void FindMaxTest_WhenLengthIsEqualsZero(ListArray actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.FindMax());
        }

        [TestCaseSource(typeof(FindMinTestSource))]
        public void FindMinTest(ListArray actualList, int expected)
        {
            int actual = actualList.FindMin();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindMaxNegativeTestSource_WhenLengthIsEqualsZero))]
        public void FindMinTest_WhenLengthIsEqualsZero(ListArray actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.FindMin());
        }

        [TestCaseSource(typeof(FindIndexOfMaxTestSource ))]
        public void FindIndexOfMaxTest(ListArray actualList, int expected)
        {
            int actual = actualList.FindIndexOfMax();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindIndexOfMaxNegativeTestSource_WhenLengthIsEqualsZero))]
        public void FindIndexOfMaxTest_WhenLengthIsEqualsZero(ListArray actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.FindIndexOfMax());
        }

        [TestCaseSource(typeof(FindIndexOfMinTestSource))]
        public void FindIndexOfMinTest(ListArray actualList, int expected)
        {
            int actual = actualList.FindIndexOfMin();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindIndexOfMinNegativeTestSource_WhenLengthIsEqualsZero))]
        public void FindIndexOfMinTest_WhenLengthIsEqualsZero(ListArray actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.FindIndexOfMin());
        }


        [TestCaseSource(typeof(SortLessBiggerTestSource))]
        public void SortLessBiggerTest(ListArray actualList, ListArray expected)
        {
            actualList.SortLessBigger();
            Assert.AreEqual(expected, actualList);
        }


        [TestCaseSource(typeof(SortBiggerLessTestSource))]
        public void SortBiggerLessTest(ListArray actualList, ListArray expected)
        {
            actualList.SortBiggerLess();
            Assert.AreEqual(expected, actualList);
        }


        [TestCaseSource(typeof(DeleteFirstFoundTestSource))]
        public void DeleteFirstFoundTest(int value, ListArray actualList, ListArray expected, int actualIndex)
        {
            int expectedIndex = actualList.DeleteFirstFound(value);
            Assert.AreEqual(expected, actualList);
            Assert.AreEqual(expectedIndex, actualIndex);
        }

        [TestCaseSource(typeof(DeleteFirstFoundNegativeTest_WhenLengthIsEqualsZero))]
        public void DeleteFirstFoundTest_WhenLengthIsEqualsZero(int value, ListArray actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.DeleteFirstFound(value));
        }

        [TestCaseSource(typeof(DeleteAllFoundElementsTesSource))]
        public void DeleteAllFoundElementsTest(int value, ListArray actualList, ListArray expected, int actualNumber)
        {
            int expectedNumber = actualList.DeleteAllFoundElements(value);
            Assert.AreEqual(expected, actualList);
            Assert.AreEqual(expectedNumber, actualNumber);
        }

        [TestCaseSource(typeof(DeleteAllFoundElementsNegativeTest_WhenLengthIsEqualsZero))]
        public void DeleteAllFoundElementsTest_WhenLengthIsEqualsZero(int value, ListArray actuallist)
        {
            Assert.Throws<Exception>(() => actuallist.DeleteFirstFound(value));
        }

        [TestCaseSource(typeof(AppendListTestSource))]
        public void AppendListTest(ListArray list, ListArray actualList, ListArray expected)
        {
            actualList.AppendList(list);
            Assert.AreEqual(expected, actualList);
            
        }

        [TestCaseSource(typeof(NegativeTestSource_WhenListIsNull))]
        public void AppendListTest_WhenListIsNull(ListArray list, ListArray actuallist)
        {
            Assert.Throws<ArgumentNullException>(() => actuallist.AppendList(list));
        }


        [TestCaseSource(typeof(AddListToBeginTestSource))]
        public void AddListToBeginTest(ListArray list, ListArray actualList, ListArray expected)
        {
            actualList.AddListToBegin(list);
            Assert.AreEqual(expected, actualList);

        }

        [TestCaseSource(typeof(NegativeTestSource_WhenListIsNull))]
        public void AddListToBeginTest_WhenListIsNull(ListArray list, ListArray actuallist)
        {
            Assert.Throws<ArgumentNullException>(() => actuallist.AddListToBegin(list));
        }

        [TestCaseSource(typeof(AddListByIndexTestSource))]
        public void AddListByIndexTest(int index, ListArray list, ListArray actualList, ListArray expected)
        {
            actualList.AddListByIndex(index, list);
            Assert.AreEqual(expected, actualList);

        }

        [TestCaseSource(typeof(AddListByIndexNegativeTestSource_WhenIndexOutOfLength))]
        public void AddListByIndexTest_WhenListIsNull(int index, ListArray list, ListArray actuallist)
        {
            Assert.Throws<IndexOutOfRangeException>(() => actuallist.AddListByIndex(index, list));
        }
    }
}