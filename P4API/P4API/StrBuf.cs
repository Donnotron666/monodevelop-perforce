/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.33
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace P4API {

using System;
using System.Runtime.InteropServices;

public class StrBuf : StrPtr {
  private HandleRef swigCPtr;

  internal StrBuf(IntPtr cPtr, bool cMemoryOwn) : base(p4apiPINVOKE.StrBufUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(StrBuf obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~StrBuf() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        p4apiPINVOKE.delete_StrBuf(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public StrBuf() : this(p4apiPINVOKE.new_StrBuf__SWIG_0(), true) {
  }

  public void StringInit() {
    p4apiPINVOKE.StrBuf_StringInit(swigCPtr);
  }

  public StrBuf(StrBuf s) : this(p4apiPINVOKE.new_StrBuf__SWIG_1(StrBuf.getCPtr(s)), true) {
    if (p4apiPINVOKE.SWIGPendingException.Pending) throw p4apiPINVOKE.SWIGPendingException.Retrieve();
  }

  public StrBuf(StrRef s) : this(p4apiPINVOKE.new_StrBuf__SWIG_2(StrRef.getCPtr(s)), true) {
    if (p4apiPINVOKE.SWIGPendingException.Pending) throw p4apiPINVOKE.SWIGPendingException.Retrieve();
  }

  public StrBuf(StrPtr s) : this(p4apiPINVOKE.new_StrBuf__SWIG_3(StrPtr.getCPtr(s)), true) {
    if (p4apiPINVOKE.SWIGPendingException.Pending) throw p4apiPINVOKE.SWIGPendingException.Retrieve();
  }

  public StrBuf(string buf) : this(p4apiPINVOKE.new_StrBuf__SWIG_4(buf), true) {
  }

  public void Clear() {
    p4apiPINVOKE.StrBuf_Clear(swigCPtr);
  }

  public void Set(string buf) {
    p4apiPINVOKE.StrBuf_Set__SWIG_0(swigCPtr, buf);
  }

  public void Set(StrPtr s) {
    p4apiPINVOKE.StrBuf_Set__SWIG_1(swigCPtr, StrPtr.getCPtr(s));
  }

  public void Set(string buf, int len) {
    p4apiPINVOKE.StrBuf_Set__SWIG_3(swigCPtr, buf, len);
  }

  public void Extend(string buf, int len) {
    p4apiPINVOKE.StrBuf_Extend__SWIG_0(swigCPtr, buf, len);
  }

  public void Extend(char c) {
    p4apiPINVOKE.StrBuf_Extend__SWIG_1(swigCPtr, c);
  }

  public void Terminate() {
    p4apiPINVOKE.StrBuf_Terminate(swigCPtr);
  }

  public void Append(string buf) {
    p4apiPINVOKE.StrBuf_Append__SWIG_0(swigCPtr, buf);
  }

  public void Append(StrPtr s) {
    p4apiPINVOKE.StrBuf_Append__SWIG_1(swigCPtr, StrPtr.getCPtr(s));
  }

  public void Append(string buf, int len) {
    p4apiPINVOKE.StrBuf_Append__SWIG_2(swigCPtr, buf, len);
  }

  public string Alloc(int len) {
    string ret = p4apiPINVOKE.StrBuf_Alloc(swigCPtr, len);
    return ret;
  }

}

}
