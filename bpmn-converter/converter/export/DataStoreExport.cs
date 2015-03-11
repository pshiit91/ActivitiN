namespace org.activiti.bpmn.converter.export{








public class DataStoreExport implements BpmnXMLConstants {

  public static void writeDataStores(BpmnModel model, XMLStreamWriter xtw) throws Exception {
    
    for (DataStore dataStore : model.getDataStores().values()) {
      xtw.writeStartElement(ELEMENT_DATA_STORE);
      xtw.writeAttribute(ATTRIBUTE_ID, dataStore.getId());
      xtw.writeAttribute(ATTRIBUTE_NAME, dataStore.getName());
      if (StringUtils.isNotEmpty(dataStore.getItemSubjectRef())) {
        xtw.writeAttribute(ATTRIBUTE_ITEM_SUBJECT_REF, dataStore.getItemSubjectRef());
      }
      
      if (StringUtils.isNotEmpty(dataStore.getDataState())) {
        xtw.writeStartElement(ELEMENT_DATA_STATE);
        xtw.writeCharacters(dataStore.getDataState());
        xtw.writeEndElement();
      }
      
      xtw.writeEndElement();
    }
  }
}
