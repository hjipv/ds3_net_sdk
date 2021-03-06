/*
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

// This code is auto-generated, do not modify
using Ds3.Models;
using System;
using System.Net;

namespace Ds3.Calls
{
    public class GetCanceledJobsSpectraS3Request : Ds3Request
    {
        
        
        private string _bucketId;
        public string BucketId
        {
            get { return _bucketId; }
            set { WithBucketId(value); }
        }

        private bool? _canceledDueToTimeout;
        public bool? CanceledDueToTimeout
        {
            get { return _canceledDueToTimeout; }
            set { WithCanceledDueToTimeout(value); }
        }

        private JobChunkClientProcessingOrderGuarantee? _chunkClientProcessingOrderGuarantee;
        public JobChunkClientProcessingOrderGuarantee? ChunkClientProcessingOrderGuarantee
        {
            get { return _chunkClientProcessingOrderGuarantee; }
            set { WithChunkClientProcessingOrderGuarantee(value); }
        }

        private bool? _lastPage;
        public bool? LastPage
        {
            get { return _lastPage; }
            set { WithLastPage(value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { WithName(value); }
        }

        private int? _pageLength;
        public int? PageLength
        {
            get { return _pageLength; }
            set { WithPageLength(value); }
        }

        private int? _pageOffset;
        public int? PageOffset
        {
            get { return _pageOffset; }
            set { WithPageOffset(value); }
        }

        private string _pageStartMarker;
        public string PageStartMarker
        {
            get { return _pageStartMarker; }
            set { WithPageStartMarker(value); }
        }

        private Priority? _priority;
        public Priority? Priority
        {
            get { return _priority; }
            set { WithPriority(value); }
        }

        private DateTime? _rechunked;
        public DateTime? Rechunked
        {
            get { return _rechunked; }
            set { WithRechunked(value); }
        }

        private JobRequestType? _requestType;
        public JobRequestType? RequestType
        {
            get { return _requestType; }
            set { WithRequestType(value); }
        }

        private bool? _truncated;
        public bool? Truncated
        {
            get { return _truncated; }
            set { WithTruncated(value); }
        }

        private string _userId;
        public string UserId
        {
            get { return _userId; }
            set { WithUserId(value); }
        }

        
        public GetCanceledJobsSpectraS3Request WithBucketId(Guid? bucketId)
        {
            this._bucketId = bucketId.ToString();
            if (bucketId != null)
            {
                this.QueryParams.Add("bucket_id", bucketId.ToString());
            }
            else
            {
                this.QueryParams.Remove("bucket_id");
            }
            return this;
        }

        
        public GetCanceledJobsSpectraS3Request WithBucketId(string bucketId)
        {
            this._bucketId = bucketId;
            if (bucketId != null)
            {
                this.QueryParams.Add("bucket_id", bucketId);
            }
            else
            {
                this.QueryParams.Remove("bucket_id");
            }
            return this;
        }

        
        public GetCanceledJobsSpectraS3Request WithCanceledDueToTimeout(bool? canceledDueToTimeout)
        {
            this._canceledDueToTimeout = canceledDueToTimeout;
            if (canceledDueToTimeout != null)
            {
                this.QueryParams.Add("canceled_due_to_timeout", canceledDueToTimeout.ToString());
            }
            else
            {
                this.QueryParams.Remove("canceled_due_to_timeout");
            }
            return this;
        }

        
        public GetCanceledJobsSpectraS3Request WithChunkClientProcessingOrderGuarantee(JobChunkClientProcessingOrderGuarantee? chunkClientProcessingOrderGuarantee)
        {
            this._chunkClientProcessingOrderGuarantee = chunkClientProcessingOrderGuarantee;
            if (chunkClientProcessingOrderGuarantee != null)
            {
                this.QueryParams.Add("chunk_client_processing_order_guarantee", chunkClientProcessingOrderGuarantee.ToString());
            }
            else
            {
                this.QueryParams.Remove("chunk_client_processing_order_guarantee");
            }
            return this;
        }

        
        public GetCanceledJobsSpectraS3Request WithLastPage(bool? lastPage)
        {
            this._lastPage = lastPage;
            if (lastPage != null)
            {
                this.QueryParams.Add("last_page", lastPage.ToString());
            }
            else
            {
                this.QueryParams.Remove("last_page");
            }
            return this;
        }

        
        public GetCanceledJobsSpectraS3Request WithName(string name)
        {
            this._name = name;
            if (name != null)
            {
                this.QueryParams.Add("name", name);
            }
            else
            {
                this.QueryParams.Remove("name");
            }
            return this;
        }

        
        public GetCanceledJobsSpectraS3Request WithPageLength(int? pageLength)
        {
            this._pageLength = pageLength;
            if (pageLength != null)
            {
                this.QueryParams.Add("page_length", pageLength.ToString());
            }
            else
            {
                this.QueryParams.Remove("page_length");
            }
            return this;
        }

        
        public GetCanceledJobsSpectraS3Request WithPageOffset(int? pageOffset)
        {
            this._pageOffset = pageOffset;
            if (pageOffset != null)
            {
                this.QueryParams.Add("page_offset", pageOffset.ToString());
            }
            else
            {
                this.QueryParams.Remove("page_offset");
            }
            return this;
        }

        
        public GetCanceledJobsSpectraS3Request WithPageStartMarker(Guid? pageStartMarker)
        {
            this._pageStartMarker = pageStartMarker.ToString();
            if (pageStartMarker != null)
            {
                this.QueryParams.Add("page_start_marker", pageStartMarker.ToString());
            }
            else
            {
                this.QueryParams.Remove("page_start_marker");
            }
            return this;
        }

        
        public GetCanceledJobsSpectraS3Request WithPageStartMarker(string pageStartMarker)
        {
            this._pageStartMarker = pageStartMarker;
            if (pageStartMarker != null)
            {
                this.QueryParams.Add("page_start_marker", pageStartMarker);
            }
            else
            {
                this.QueryParams.Remove("page_start_marker");
            }
            return this;
        }

        
        public GetCanceledJobsSpectraS3Request WithPriority(Priority? priority)
        {
            this._priority = priority;
            if (priority != null)
            {
                this.QueryParams.Add("priority", priority.ToString());
            }
            else
            {
                this.QueryParams.Remove("priority");
            }
            return this;
        }

        
        public GetCanceledJobsSpectraS3Request WithRechunked(DateTime? rechunked)
        {
            this._rechunked = rechunked;
            if (rechunked != null)
            {
                this.QueryParams.Add("rechunked", rechunked.ToString());
            }
            else
            {
                this.QueryParams.Remove("rechunked");
            }
            return this;
        }

        
        public GetCanceledJobsSpectraS3Request WithRequestType(JobRequestType? requestType)
        {
            this._requestType = requestType;
            if (requestType != null)
            {
                this.QueryParams.Add("request_type", requestType.ToString());
            }
            else
            {
                this.QueryParams.Remove("request_type");
            }
            return this;
        }

        
        public GetCanceledJobsSpectraS3Request WithTruncated(bool? truncated)
        {
            this._truncated = truncated;
            if (truncated != null)
            {
                this.QueryParams.Add("truncated", truncated.ToString());
            }
            else
            {
                this.QueryParams.Remove("truncated");
            }
            return this;
        }

        
        public GetCanceledJobsSpectraS3Request WithUserId(Guid? userId)
        {
            this._userId = userId.ToString();
            if (userId != null)
            {
                this.QueryParams.Add("user_id", userId.ToString());
            }
            else
            {
                this.QueryParams.Remove("user_id");
            }
            return this;
        }

        
        public GetCanceledJobsSpectraS3Request WithUserId(string userId)
        {
            this._userId = userId;
            if (userId != null)
            {
                this.QueryParams.Add("user_id", userId);
            }
            else
            {
                this.QueryParams.Remove("user_id");
            }
            return this;
        }


        
        
        public GetCanceledJobsSpectraS3Request()
        {
            
        }

        internal override HttpVerb Verb
        {
            get
            {
                return HttpVerb.GET;
            }
        }

        internal override string Path
        {
            get
            {
                return "/_rest_/canceled_job";
            }
        }
    }
}