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
using Ds3.Models;
using System;
using System.Net;

namespace Ds3.Calls
{
    public class ImportAllTapesSpectraS3Request : Ds3Request
    {
        
        
        private ImportConflictResolutionMode _conflictResolutionMode;
        public ImportConflictResolutionMode ConflictResolutionMode
        {
            get { return _conflictResolutionMode; }
            set { WithConflictResolutionMode(value); }
        }

        public ImportAllTapesSpectraS3Request WithConflictResolutionMode(ImportConflictResolutionMode conflictResolutionMode)
        {
            this._conflictResolutionMode = conflictResolutionMode;
            if (conflictResolutionMode != null) {
                this.QueryParams.Add("conflict_resolution_mode", ConflictResolutionMode.ToString());
            }
            else
            {
                this.QueryParams.Remove("conflict_resolution_mode");
            }
            return this;
        }

        private Guid _dataPolicyId;
        public Guid DataPolicyId
        {
            get { return _dataPolicyId; }
            set { WithDataPolicyId(value); }
        }

        public ImportAllTapesSpectraS3Request WithDataPolicyId(Guid dataPolicyId)
        {
            this._dataPolicyId = dataPolicyId;
            if (dataPolicyId != null) {
                this.QueryParams.Add("data_policy_id", DataPolicyId.ToString());
            }
            else
            {
                this.QueryParams.Remove("data_policy_id");
            }
            return this;
        }

        private Guid _storageDomainId;
        public Guid StorageDomainId
        {
            get { return _storageDomainId; }
            set { WithStorageDomainId(value); }
        }

        public ImportAllTapesSpectraS3Request WithStorageDomainId(Guid storageDomainId)
        {
            this._storageDomainId = storageDomainId;
            if (storageDomainId != null) {
                this.QueryParams.Add("storage_domain_id", StorageDomainId.ToString());
            }
            else
            {
                this.QueryParams.Remove("storage_domain_id");
            }
            return this;
        }

        private Guid _userId;
        public Guid UserId
        {
            get { return _userId; }
            set { WithUserId(value); }
        }

        public ImportAllTapesSpectraS3Request WithUserId(Guid userId)
        {
            this._userId = userId;
            if (userId != null) {
                this.QueryParams.Add("user_id", UserId.ToString());
            }
            else
            {
                this.QueryParams.Remove("user_id");
            }
            return this;
        }

        public ImportAllTapesSpectraS3Request() {
            this.QueryParams.Add("operation", "import");
            
        }

        internal override HttpVerb Verb
        {
            get
            {
                return HttpVerb.PUT;
            }
        }

        internal override string Path
        {
            get
            {
                return "/_rest_/tape/";
            }
        }
    }
}