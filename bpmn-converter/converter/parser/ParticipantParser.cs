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
namespace org.activiti.bpmn.converter.parser{











/**
 * @author Tijs Rademakers
 */
public class ParticipantParser : BpmnXMLConstants {
  
  protected static final Logger LOGGER = LoggerFactory.getLogger(ParticipantParser.class.getName());
  
  public void parse(XMLStreamReader xtr, BpmnModel model) throws Exception {
    
    if (StringUtils.isNotEmpty(xtr.getAttributeValue(null, ATTRIBUTE_ID))) {
      Pool pool = new Pool();
      pool.setId(xtr.getAttributeValue(null, ATTRIBUTE_ID));
      pool.setName(xtr.getAttributeValue(null, ATTRIBUTE_NAME));
      pool.setProcessRef(xtr.getAttributeValue(null, ATTRIBUTE_PROCESS_REF));
      BpmnXMLUtil.parseChildElements(ELEMENT_PARTICIPANT, pool, xtr, model);
      model.getPools().add(pool);
    }
  }
}
