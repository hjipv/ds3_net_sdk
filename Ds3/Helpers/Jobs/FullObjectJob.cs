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

using Ds3.Calls;
using Ds3.Helpers.RangeTranslators;
using Ds3.Helpers.Strategies;
using Ds3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Ds3.Helpers.TransferStrategies;

namespace Ds3.Helpers.Jobs
{
    internal class FullObjectJob : Job<IJob, string>, IJob
    {
        public static IJob Create(
            IDs3Client client,
            MasterObjectList jobResponse,
            IHelperStrategy<string> helperStrategy,
            ITransferStrategy transferStrategy,
            int objectTransferAttempts = 5)
        {
            var blobs = Blob.Convert(jobResponse);
            var rangesForRequests = blobs.ToLookup(b => b, b => b.Range);
            return new FullObjectJob(
                client,
                jobResponse,
                jobResponse.BucketName,
                jobResponse.JobId,
                helperStrategy,
                transferStrategy,
                rangesForRequests,
                blobs,
                objectTransferAttempts
            );
        }

        private FullObjectJob(
            IDs3Client client,
            MasterObjectList jobResponse,
            string bucketName,
            Guid jobId,
            IHelperStrategy<string> helperStrategy,
            ITransferStrategy transferStrategy,
            ILookup<Blob, Range> rangesForRequests,
            IEnumerable<ContextRange<string>> itemsToTrack,
            int objectTransferAttempts  = 5)
                : base(
                      client,
                      jobResponse,
                      bucketName,
                      jobId,
                      helperStrategy,
                      transferStrategy,
                      rangesForRequests,
                      new RequestToObjectRangeTranslator(rangesForRequests),
                      itemsToTrack,
                      objectTransferAttempts
                      )
        {
        }
    }
}