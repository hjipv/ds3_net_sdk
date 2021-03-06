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
    public class ModifyTapeSpectraS3Request : Ds3Request
    {
        
        public string TapeId { get; private set; }

        
        private string _ejectLabel;
        public string EjectLabel
        {
            get { return _ejectLabel; }
            set { WithEjectLabel(value); }
        }

        private string _ejectLocation;
        public string EjectLocation
        {
            get { return _ejectLocation; }
            set { WithEjectLocation(value); }
        }

        private TapeState? _state;
        public TapeState? State
        {
            get { return _state; }
            set { WithState(value); }
        }

        
        public ModifyTapeSpectraS3Request WithEjectLabel(string ejectLabel)
        {
            this._ejectLabel = ejectLabel;
            if (ejectLabel != null)
            {
                this.QueryParams.Add("eject_label", ejectLabel);
            }
            else
            {
                this.QueryParams.Remove("eject_label");
            }
            return this;
        }

        
        public ModifyTapeSpectraS3Request WithEjectLocation(string ejectLocation)
        {
            this._ejectLocation = ejectLocation;
            if (ejectLocation != null)
            {
                this.QueryParams.Add("eject_location", ejectLocation);
            }
            else
            {
                this.QueryParams.Remove("eject_location");
            }
            return this;
        }

        
        public ModifyTapeSpectraS3Request WithState(TapeState? state)
        {
            this._state = state;
            if (state != null)
            {
                this.QueryParams.Add("state", state.ToString());
            }
            else
            {
                this.QueryParams.Remove("state");
            }
            return this;
        }


        
        
        public ModifyTapeSpectraS3Request(Guid tapeId)
        {
            this.TapeId = tapeId.ToString();
            
        }

        
        public ModifyTapeSpectraS3Request(string tapeId)
        {
            this.TapeId = tapeId;
            
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
                return "/_rest_/tape/" + TapeId.ToString();
            }
        }
    }
}