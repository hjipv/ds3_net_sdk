﻿/*
 * ******************************************************************************
 *   Copyright 2014-2016 Spectra Logic Corporation. All Rights Reserved.
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

using System;
using System.Collections.Generic;
using System.IO;
using Ds3.Calls;
using Ds3.Models;

namespace Ds3.Helpers.Transferrers
{
    internal class ReadTransferrer : ITransferrer
    {
        public void Transfer(IDs3Client client, string bucketName, string objectName, long blobOffset, Guid jobId,
            IEnumerable<Range> ranges, Stream stream, IMetadataAccess metadataAccess,
            Action<string, IDictionary<string, string>> metadataListener, int objectTransferAttempts)
        {
            var response = client.GetObject(new GetObjectRequest(bucketName, objectName, stream, jobId, blobOffset));
            if (blobOffset == 0)
            {
                metadataListener?.Invoke(objectName, MetadataUtils.GetUriUnEscapeMetadata(response.Metadata));
            }
        }
    }
}