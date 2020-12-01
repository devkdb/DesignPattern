using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 우리 회사에서 PayX 인터페이스 구현
// public class PayImpl : PayX {

// 	private string creditCardNum;

// 	public string getCreditCardNum () {
// 		Debug.Log ("PayX (Get)");
// 		return creditCardNum;
// 	}

// 	public void setCreditCardNum (string creditCardNum) {
// 		Debug.Log ("PayX (Set)");
// 		this.creditCardNum = creditCardNum;
// 	}
// }

// 우리 회사에서 PayY 인터페이스 구현
public class PayImpl : PayY, PayX {

    // for PayY
    private string customerCardNum;

	public string getCustomerCardNum() {
		Debug.Log ("PayY (Get)");
		return customerCardNum;
	}

	public void setCustomerCardNum (string customerCardNum) {
		Debug.Log ("PayY (Set)");
		this.customerCardNum = customerCardNum;
	}

	// ------------------------------------------------------

	// for PayX Method
    public string getCreditCardNum()
    {
        return getCustomerCardNum();
    }

    public void setCreditCardNum(string creditCardNum)
    {
        setCustomerCardNum(creditCardNum);
    }
}
