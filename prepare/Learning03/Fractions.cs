using System;
class Fraction{
    private int _top;
    private int _bottom;
    public void Test(){
        _top = 1;
        _bottom = 1;
    }
    public void Test(int top){
        _top = top;
        _bottom = 1;
    }
    public void Test(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }
}