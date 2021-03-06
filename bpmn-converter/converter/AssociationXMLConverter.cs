/* Licensed under the Apache License, Version 2.0 (the "License");<(.*) extends (.*)>
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
using bpmn_converter.converter.util;
using org.activiti.bpmn.converter.util;
using org.activiti.bpmn.model;

namespace org.activiti.bpmn.converter{









/**
 * //@author Tijs Rademakers

 */
public class AssociationXMLConverter : BaseBpmnXMLConverter {
  
  public Type getBpmnElementType() {
    return typeof(Association);
  }
  
  //@Override

  protected String getXMLElementName() {
    return ELEMENT_ASSOCIATION;
  }
  
  //@Override

  protected BaseElement convertXMLToElement(XMLStreamReader xtr, BpmnModel model) {
    Association association = new Association();
    BpmnXMLUtil.addXMLLocation(association, xtr);
    association.setSourceRef(xtr.getAttributeValue(null, ATTRIBUTE_FLOW_SOURCE_REF));
    association.setTargetRef(xtr.getAttributeValue(null, ATTRIBUTE_FLOW_TARGET_REF));
    association.setId(xtr.getAttributeValue(null, ATTRIBUTE_ID));
    
    parseChildElements(getXMLElementName(), association, model, xtr);

    return association;
  }

  //@Override

  protected void writeAdditionalAttributes(BaseElement element, BpmnModel model, XMLStreamWriter xtw) {
    Association association = (Association) element;
    writeDefaultAttribute(ATTRIBUTE_FLOW_SOURCE_REF, association.getSourceRef(), xtw);
    writeDefaultAttribute(ATTRIBUTE_FLOW_TARGET_REF, association.getTargetRef(), xtw);
  }
  
  //@Override

  protected void writeAdditionalChildElements(BaseElement element, BpmnModel model, XMLStreamWriter xtw) {
  }
}
