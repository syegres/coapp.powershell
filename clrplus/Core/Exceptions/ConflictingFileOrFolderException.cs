﻿//-----------------------------------------------------------------------
// <copyright company="CoApp Project" >
//     Copyright (c) 2010-2013 Garrett Serack and CoApp Contributors. 
//     Contributors can be discovered using the 'git log' command.
//     All rights reserved.
// </copyright>
// <license>
//     The software is licensed under the Apache 2.0 License (the "License")
//     You may not use the software except in compliance with the License. 
// </license>
//-----------------------------------------------------------------------

namespace ClrPlus.Core.Exceptions {
    public class ConflictingFileOrFolderException : ClrPlusException {
        public string ConflictedPath {get; set;}

        public ConflictingFileOrFolderException(string path) {
            ConflictedPath = path;
        }
    }
}