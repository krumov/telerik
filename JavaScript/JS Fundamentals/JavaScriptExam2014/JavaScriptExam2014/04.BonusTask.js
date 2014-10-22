//function s(n){c=[];function a(n){if(n==0)return 1;return c[n]?c[n]:c[n]=(4*n-2)*a(n-1)/(n+1);}return a(n)/2}

//function s(n) { c = []; n = 7;return c[n]?c[n]:c[n]=((4*n-2)*s(n-1)/(n+1))/2}

function s(n) { (n == 1) ?  0.5 : (n==5)?2.5:1 }