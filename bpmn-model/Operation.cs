using System;
using System.Collections.Generic;
using System.Linq;

namespace org.activiti.bpmn.model
{




    public class Operation : BaseElement
    {

        protected String name;
        protected String implementationRef;
        protected String inMessageRef;
        protected String outMessageRef;
        protected List<String> errorMessageRef = new List<String>();

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getImplementationRef()
        {
            return implementationRef;
        }

        public void setImplementationRef(String implementationRef)
        {
            this.implementationRef = implementationRef;
        }

        public String getInMessageRef()
        {
            return inMessageRef;
        }

        public void setInMessageRef(String inMessageRef)
        {
            this.inMessageRef = inMessageRef;
        }

        public String getOutMessageRef()
        {
            return outMessageRef;
        }

        public void setOutMessageRef(String outMessageRef)
        {
            this.outMessageRef = outMessageRef;
        }

        public List<String> getErrorMessageRef()
        {
            return errorMessageRef;
        }

        public void setErrorMessageRef(List<String> errorMessageRef)
        {
            this.errorMessageRef = errorMessageRef;
        }

        public override Object clone()
        {
            Operation clone = new Operation();
            clone.setValues(this);
            return clone;
        }

        public void setValues(Operation otherElement)
        {
            base.setValues(otherElement);
            setName(otherElement.getName());
            setImplementationRef(otherElement.getImplementationRef());
            setInMessageRef(otherElement.getInMessageRef());
            setOutMessageRef(otherElement.getOutMessageRef());

            errorMessageRef = new List<String>();
            if (otherElement.getErrorMessageRef() != null && otherElement.getErrorMessageRef().Any())
            {
                errorMessageRef.AddRange(otherElement.getErrorMessageRef());
            }
        }
    }
}