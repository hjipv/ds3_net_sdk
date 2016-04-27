/*
 * ******************************************************************************
 *   Copyright 2014-2015 Spectra Logic Corporation. All Rights Reserved.
 *   Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *   this file except in compliance with the License. A copy of the License is located at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 *   or in the "license" file accompanying this file.
 *   This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *   CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *   specific language governing permissions and limitations under the License.
 * ****************************************************************************
 */

// This code is auto-generated, do not modify

using System;
using System.Collections.Generic;

namespace Ds3.Models
{
    public class ListPartsResult
    {
        public string Bucket { get; set; }
        public string Key { get; set; }
        public int MaxParts { get; set; }
        public int NextPartNumberMarker { get; set; }
        public User Owner { get; set; }
        public int? PartNumberMarker { get; set; }
        public IEnumerable<MultiPartUploadPart> Parts { get; set; }
        public bool Truncated { get; set; }
        public Guid UploadId { get; set; }
    }
}
