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
    public class GetBucketCapacitySummarySpectraS3Request : Ds3Request
    {
        
        public string BucketId { get; private set; }

        public string StorageDomainId { get; private set; }

        
        private PoolHealth? _poolHealth;
        public PoolHealth? PoolHealth
        {
            get { return _poolHealth; }
            set { WithPoolHealth(value); }
        }

        private PoolState? _poolState;
        public PoolState? PoolState
        {
            get { return _poolState; }
            set { WithPoolState(value); }
        }

        private PoolType? _poolType;
        public PoolType? PoolType
        {
            get { return _poolType; }
            set { WithPoolType(value); }
        }

        private TapeState? _tapeState;
        public TapeState? TapeState
        {
            get { return _tapeState; }
            set { WithTapeState(value); }
        }

        private TapeType? _tapeType;
        public TapeType? TapeType
        {
            get { return _tapeType; }
            set { WithTapeType(value); }
        }

        
        public GetBucketCapacitySummarySpectraS3Request WithPoolHealth(PoolHealth? poolHealth)
        {
            this._poolHealth = poolHealth;
            if (poolHealth != null)
            {
                this.QueryParams.Add("pool_health", poolHealth.ToString());
            }
            else
            {
                this.QueryParams.Remove("pool_health");
            }
            return this;
        }

        
        public GetBucketCapacitySummarySpectraS3Request WithPoolState(PoolState? poolState)
        {
            this._poolState = poolState;
            if (poolState != null)
            {
                this.QueryParams.Add("pool_state", poolState.ToString());
            }
            else
            {
                this.QueryParams.Remove("pool_state");
            }
            return this;
        }

        
        public GetBucketCapacitySummarySpectraS3Request WithPoolType(PoolType? poolType)
        {
            this._poolType = poolType;
            if (poolType != null)
            {
                this.QueryParams.Add("pool_type", poolType.ToString());
            }
            else
            {
                this.QueryParams.Remove("pool_type");
            }
            return this;
        }

        
        public GetBucketCapacitySummarySpectraS3Request WithTapeState(TapeState? tapeState)
        {
            this._tapeState = tapeState;
            if (tapeState != null)
            {
                this.QueryParams.Add("tape_state", tapeState.ToString());
            }
            else
            {
                this.QueryParams.Remove("tape_state");
            }
            return this;
        }

        
        public GetBucketCapacitySummarySpectraS3Request WithTapeType(TapeType? tapeType)
        {
            this._tapeType = tapeType;
            if (tapeType != null)
            {
                this.QueryParams.Add("tape_type", tapeType.ToString());
            }
            else
            {
                this.QueryParams.Remove("tape_type");
            }
            return this;
        }


        
        
        public GetBucketCapacitySummarySpectraS3Request(Guid bucketId, Guid storageDomainId)
        {
            this.BucketId = bucketId.ToString();
            this.StorageDomainId = storageDomainId.ToString();
            
            this.QueryParams.Add("bucket_id", bucketId.ToString());

            this.QueryParams.Add("storage_domain_id", storageDomainId.ToString());

        }

        
        public GetBucketCapacitySummarySpectraS3Request(string bucketId, string storageDomainId)
        {
            this.BucketId = bucketId;
            this.StorageDomainId = storageDomainId;
            
            this.QueryParams.Add("bucket_id", bucketId);

            this.QueryParams.Add("storage_domain_id", storageDomainId);

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
                return "/_rest_/capacity_summary";
            }
        }
    }
}