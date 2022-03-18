﻿namespace ListArray
{
    public class ListArray
    {
        public int Length { get;private set; }

        private int[] _array;

        public ListArray()
        {
            _array = new int[5];
            Length = 2;
        }

        public ListArray(int Length)
        {
            _array = new int[(int)(Length * 1.5)];
            this.Length = Length;
        }

        public ListArray(int[] array)
        {
            _array = array;
            Length = _array.Length;
        }

        public void AddLast(int value)
        {
            if(Length >= _array.Length)
            {
                IncreaseLengthOfArray();
            }

            _array[Length] = value;
            Length++;
        }

        public void AddFirst(int value)
        {
            if (Length + 1 >= _array.Length)
            {
                IncreaseLengthOfArray();
            }

            MoveRightSide();

            _array[0] = value;
        }

        public void AddByIndex(int num, int value)
        {
            if (Length + 1 >= _array.Length)
            {
                IncreaseLengthOfArray();
            }

            MoveRightSide(num);

            _array[num] = _array[value];
        }

        public void DeleteLast()
        {
            if (Length < 1)
            {
                throw new Exception("List have nothing to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthOfArray();
            }
            Length--;
        }

        public void DeletFirst()
        {
            if (_array.Length < 1)
            {
                throw new Exception("List have nothing to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthOfArray();
            }

            MoveLeftSide();
        }

        public void DeleteByIndex(int num)
        {
            if (Length < 1)
            {
                throw new Exception("List have nothing to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthOfArray();
            }

            MoveLeftSideFromAnyPart(num);
        }

        public void DeleteRangeOfLast(int rangeLength)
        {
            if (Length < rangeLength)
            {
                throw new Exception("List have no so many elements you want to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthOfArray();
            }

            for (int i = 0; i < rangeLength; i++)
            {
                Length--;
            }
        }

        public void DeleteRangeOfFirst(int rangeLength)
        {
            if (Length < rangeLength)
            {
                throw new Exception("List have no so many elements you want to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthOfArray();
            }

            for (int i=0; i < rangeLength; i++)
            {
                MoveLeftSide();
            }
        }

        public void DeleteRangeByIndex(int index, int rangeLength)
        {
            if (Length < 1)
            {
                throw new Exception("List have nothing to delete");
            }
            if (Length <= _array.Length / 2)
            {
                DecreaseLengthOfArray();
            }

            for (int i=0; i<rangeLength; i++)
            {
                MoveLeftSideFromAnyPart(index);
            }
        }

        public int FindIndexByFirstElement(int num)
        {
            if(Length == 0)
            {
                throw new Exception("You have nothing to find");
            }
            int neededIndex = -1;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == num)
                {
                    neededIndex = i;
                    break;
                }
            }
            return neededIndex;
        }

        public void ChangeElementByindex(int index, int value)
        {
            if (Length == 0)
            {
                throw new Exception("You have nothing to change");
            }
            if (Length < index)
            {
                throw new IndexOutOfRangeException("Length have to be greater than index");
            }

            _array[index] = value;
        }

        public void Reverse()
        {
            int[] tmpArr = new int[Length];
            int j = 0;

            for (int i = Length - 1; i >= 0; i--)
            {
                tmpArr[j] = _array[i];
                j++;
            }

            _array = tmpArr;
        }

        public int FindMax()
        {
            if (Length == 0)
            {
                throw new Exception("You have nothing to find");
            }
            int max = _array[0];
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }
            return max;
        }

        public int FindMin()
        {
            if (Length == 0)
            {
                throw new Exception("You have nothing to find");
            }
            int min = _array[0];
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }
            return min;
        }

        public int FindIndexOfMax()
        {
            if (Length == 0)
            {
                throw new Exception("You have nothing to find");
            }
            int maxIndex = 0;
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] > _array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        public int FindIndexOfMin()
        {
            if (Length == 0)
            {
                throw new Exception("You have nothing to find");
            }
            int minIndex = 0;
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] < _array[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }

        public void SortLessBigger()
        {
            for (int i = 0; i < Length - 1; i++)
            {
                for (int j = Length - 1; j > 0; j--)
                {
                    if (_array[j] < _array[j - 1])
                    {
                        SwapNums(ref _array[j], ref _array[j - 1]);
                    }
                }
            }
        }

        public void SortBiggerLess()
        {
            int[] tmpArr = new int[Length];

            for (int i = 0; i < Length; i++)
            {
                int count = Length;
                for (int j = 0; j < Length; j++)
                {
                    if (_array[i] > _array[j])
                    {
                        count--;

                    }
                }
                tmpArr[count - 1] = _array[i];
            }

            _array = tmpArr;
        }

        public int DeleteFirstFound(int value)
        {
            if (Length == 0)
            {
                throw new Exception("You have nothing to delete");
            }

            int index = -1;

            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    index = i;
                    MoveLeftSideFromAnyPart(i);
                    break;
                }
            }

            return index;

        }

        public int DeleteAllFoundElements(int value)
        {
            if (Length == 0)
            {
                throw new Exception("You have nothing to delete");
            }

            int count = 0;

            for (int i=0; i<Length; i++)
            {
                if (_array[i] == value)
                {
                    count++;
                    MoveLeftSideFromAnyPart();
                }
            }
            return count;
        }

        private void MoveRightSide(int index=0)
        {
            int[] newArr = new int[Length+1];
            for (int i = index; i < Length; i++)
            {
                newArr[i+1] = _array[i];
            }
            _array = newArr;
        }

        private void MoveLeftSideFromAnyPart(int index = 0)
        {
            Length--;
            int[] newArr = new int[Length];
            for (int i = 0; i < index; i++)
            {
                newArr[i] = _array[i];
            }
            for (int i = index; i < Length; i++)
            {
                newArr[i] = _array[i+1];
            }
            _array = newArr;
        }

        private void MoveLeftSide()
        {
            Length--;
            int[] newArr = new int[Length];
            for (int i = 0; i < Length; i++)
            {
                newArr[i] = _array[i + 1];
            }
            _array = newArr;
        }

        private void IncreaseLengthOfArray()
        {
            int newLength = (int)(_array.Length * 1.5);
            int[] newArr = new int[newLength];
            Copy(newArr);       
        }

        private void DecreaseLengthOfArray()
        {
            int newLength = _array.Length / 3;
            int[] newArr = new int[newLength];
            Copy(newArr);
        }

        private void Copy(int[] newArr)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                newArr[i] = _array[i];
            }
            _array = newArr;
        }

        private static void SwapNums(ref int a, ref int b)
        {
            int swap = a;
            a = b;
            b = swap;
        }
    }
}