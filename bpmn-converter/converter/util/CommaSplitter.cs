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
using bpmn_converter.converter.util;

namespace org.activiti.bpmn.converter.util{




/**
 * //@author Saeid Mirzaei, Tijs Rademakers

 */

public class CommaSplitter {

  // split the given spring using commas if they are not inside an expression
  public static List<String> splitCommas(String st) {
    List<String> result = new List<String>();
    int offset = 0;
    
    bool inExpression = false;
    for (int i = 0; i < st.length(); i++) {
      if (inExpression == false && st.charAt(i) == ',') {
        if ((i - offset) > 1) {
          result.Add(st.Substring(offset, i));
        }
        offset = i + 1;
        
      } else if ((st.charAt(i) == '$' || st.charAt(i) == '#') && st.charAt(i + 1) == '{') {
        inExpression = true;
        
      } else if (st.charAt(i) == '}') {
        inExpression = false;
      }
    }
    
    if ((st.length() - offset) > 1) {
      result.Add(st.Substring(offset));
    }
    return result;
  }
}
