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
    public class ImportAzureTargetSpectraS3Request : Ds3Request
    {
        
        public string AzureTarget { get; private set; }

        public string CloudBucketName { get; private set; }

        
        private ImportConflictResolutionMode? _conflictResolutionMode;
        public ImportConflictResolutionMode? ConflictResolutionMode
        {
            get { return _conflictResolutionMode; }
            set { WithConflictResolutionMode(value); }
        }

        private string _dataPolicyId;
        public string DataPolicyId
        {
            get { return _dataPolicyId; }
            set { WithDataPolicyId(value); }
        }

        private Priority? _priority;
        public Priority? Priority
        {
            get { return _priority; }
            set { WithPriority(value); }
        }

        private string _userId;
        public string UserId
        {
            get { return _userId; }
            set { WithUserId(value); }
        }

        
        public ImportAzureTargetSpectraS3Request WithConflictResolutionMode(ImportConflictResolutionMode? conflictResolutionMode)
        {
            this._conflictResolutionMode = conflictResolutionMode;
            if (conflictResolutionMode != null)
            {
                this.QueryParams.Add("conflict_resolution_mode", conflictResolutionMode.ToString());
            }
            else
            {
                this.QueryParams.Remove("conflict_resolution_mode");
            }
            return this;
        }

        
        public ImportAzureTargetSpectraS3Request WithDataPolicyId(Guid? dataPolicyId)
        {
            this._dataPolicyId = dataPolicyId.ToString();
            if (dataPolicyId != null)
            {
                this.QueryParams.Add("data_policy_id", dataPolicyId.ToString());
            }
            else
            {
                this.QueryParams.Remove("data_policy_id");
            }
            return this;
        }

        
        public ImportAzureTargetSpectraS3Request WithDataPolicyId(string dataPolicyId)
        {
            this._dataPolicyId = dataPolicyId;
            if (dataPolicyId != null)
            {
                this.QueryParams.Add("data_policy_id", dataPolicyId);
            }
            else
            {
                this.QueryParams.Remove("data_policy_id");
            }
            return this;
        }

        
        public ImportAzureTargetSpectraS3Request WithPriority(Priority? priority)
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

        
        public ImportAzureTargetSpectraS3Request WithUserId(Guid? userId)
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

        
        public ImportAzureTargetSpectraS3Request WithUserId(string userId)
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


        
        
        public ImportAzureTargetSpectraS3Request(string azureTarget, string cloudBucketName)
        {
            this.AzureTarget = azureTarget;
            this.CloudBucketName = cloudBucketName;
            this.QueryParams.Add("operation", "import");
            
            this.QueryParams.Add("cloud_bucket_name", cloudBucketName);

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
                return "/_rest_/azure_target/" + AzureTarget;
            }
        }
    }
}