﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIProgrammer.Types
{
    /// <summary>
    /// Additional interpreter options that can be set in the constructor.
    /// </summary>
    public class InterpreterOptions
    {
        /// <summary>
        /// Controls how functions read input (,) from parent memory: either at the current memory data pointer or from the start of memory.
        /// If true, input will be read from position 0 from the parent. Meaning, the first input value that the parent read will be the first input value the function gets, regardless of the parent's current memory data position. This may make it easier for the GA to run the function, since it does not require an exact memory position before calling the function.
        /// If false (default), input will be read from the current memory data position of the parent. Meaning, if the parent has shifted the memory pointer up 3 slots, the function will begin reading from memory at position 3.
        /// </summary>
        public bool ReadFunctionInputAtMemoryStart { get; set; }
    }
}
