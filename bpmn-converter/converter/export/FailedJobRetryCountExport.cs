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
using bpmn_converter.converter;
using org.activiti.bpmn.constants;
using org.activiti.bpmn.model;

namespace org.activiti.bpmn.converter.export
{







    public class FailedJobRetryCountExport : BpmnXMLConstants
    {

        public static void writeFailedJobRetryCount(Activity activity, XMLStreamWriter xtw)
        {
            String failedJobRetryCycle = activity.getFailedJobRetryTimeCycleValue();
            if (failedJobRetryCycle != null)
            {

                if (!String.IsNullOrWhiteSpace(failedJobRetryCycle))
                {
                    xtw.writeStartElement(ACTIVITI_EXTENSIONS_PREFIX, FAILED_JOB_RETRY_TIME_CYCLE,
                        ACTIVITI_EXTENSIONS_NAMESPACE);
                    xtw.writeCharacters(failedJobRetryCycle);
                    xtw.writeEndElement();
                }
            }
        }
    }
}