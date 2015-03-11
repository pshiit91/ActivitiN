/* Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *      http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace org.activiti.bpmn.model
{

    public class Lane : BaseElement
    {

        protected String Name { get; set; }
        protected Process ParentProcess { get; set; }
        protected List<String> flowReferences = new List<String>();

        public List<string> FlowReferences
        {
            get { return flowReferences; }
            set { flowReferences = value; }
        }

        public override object clone()
        {
            Lane clone = new Lane();
            clone.setValues(this);
            return clone;
        }

        public void setValues(Lane otherElement)
        {
            base.setValues(otherElement);
            Name = otherElement.Name;
            ParentProcess = otherElement.ParentProcess;

            flowReferences = new List<String>();
            if (otherElement.FlowReferences != null && otherElement.FlowReferences.Any())
            {
                flowReferences.AddRange(otherElement.FlowReferences);
            }
        }
    }
}