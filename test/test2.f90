!=============================================================================================
! Project name: test2
! Project version: aaa
!---------------------------------------------------------------------------------------------
! Generated by Aqualis (algorithm and equation analyzer for lightwave simulation)
! Aqualis version: aaa
! Generated date: 2023/10/18 20:33:05
!=============================================================================================
program test2
implicit none
complex(kind(0d0)) :: uj=(0d0,1d0)
integer :: ic001
integer :: ic002
integer :: i001
integer :: i002
double precision :: d001
double precision :: d002
double precision :: d003
complex(kind(0d0)) :: z001
complex(kind(0d0)) :: z002
double precision,allocatable :: d1001(:)
integer :: d1001_size(1:1)=(/ -1 /)
double precision,allocatable :: d1002(:)
integer :: d1002_size(1:1)=(/ -1 /)
double precision,allocatable :: d1003(:)
integer :: d1003_size(1:1)=(/ -1 /)
double precision,allocatable :: d2001(:,:)
integer :: d2001_size(1:2)=(/ -1,-1 /)
double precision,allocatable :: d2002(:,:)
integer :: d2002_size(1:2)=(/ -1,-1 /)
double precision,allocatable :: d2003(:,:)
integer :: d2003_size(1:2)=(/ -1,-1 /)
!%%%test1%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
  !001
  i002 = 1
  !002
  i001 = i002+1
  !003
  i001 = i001+i002
  !004
  i001 = (i001+i002)*(i001+i002)
  !005
  d001 = 1
  !006
  d002 = d001/d002/d002
  !007
  i001 = i001-i002
  !008
  d001 = dble(i001)/dble(i002)
  !009
  i001 = i001/i002
  !010
  print *, i002
  print *, i002
  print *, i002+1
  !011
  i002 = -1
  !012
  i001 = 1-i002
  !013
  i001 = i002-i001
  !014
  i001 = -(i001+i002)*(i001+i002)
  !015
  d001 = dble(-(i001+i002))/(dble(i001)+dble(i002))
  !016
  d002 = -d001/d002/d002
  !017
  i001 = -(i001+i002)
  !018
  d001 = dble(-i001)/dble(i002)
  !019
  i001 = -i001/i002
  !020
  d001 = 2.0d0*dble(i001)
  !021
  i001 = 2*i001
  !022
  d002 = sin(-(d001+d002)/d001)
  d002 = cos(d001)
  d002 = tan(d001)
  d002 = exp(d001)
  d002 = log(d001)
  d002 = log10(d001)
  d002 = sqrt(d001)
  d002 = asin(d001)
  d002 = acos(d001)
  d002 = atan(d001)
  d002 = atan2(d001,d002)
  d002 = floor(d001)
  d002 = ceiling(d001)
!%%%end test1%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
!%%%test2%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
  !***debug array1 allocate check: 2*****************************
  if(d1001_size(1) /= -1) then
    print *, "ERROR2 array d1001 is already allocated"
  end if
  !****************************************************
  d1001_size(1) = 10
  allocate(d1001(1:d1001_size(1)))
  !***debug array1 allocate check: 3*****************************
  if(d1002_size(1) /= -1) then
    print *, "ERROR3 array d1002 is already allocated"
  end if
  !****************************************************
  d1002_size(1) = 10
  allocate(d1002(1:d1002_size(1)))
  !***debug array1 allocate check: 4*****************************
  if(d1003_size(1) /= -1) then
    print *, "ERROR4 array d1003 is already allocated"
  end if
  !****************************************************
  d1003_size(1) = 10
  allocate(d1003(1:d1003_size(1)))
  !021
  !***debug array1 access check: 5*****************************
  if(d1001_size(1) /= d1002_size(1)) then
    print *, "ERROR5 operator '+' array size mismatch"
  end if
  !****************************************************
  !***debug array1 access check: 6*****************************
  if(d1003_size(1) /= d1001_size(1)) then
    print *, "ERROR6 operator '<==' array size mismatch"
  end if
  !****************************************************
  do ic001=1,d1003_size(1)
    !***debug array1 access check: 7*****************************
    if(d1003_size(1) == -1) then
      print *, "ERROR7 array d1003 is not allocated"
    else if((ic001 < 1) .or. (d1003_size(1) < ic001)) then
      print *, "ERROR7 array d1003 illegal access. index ",ic001," is out of range (1:",d1003_size( &
      1),")"
    end if
    !****************************************************
    !***debug array1 access check: 8*****************************
    if(d1001_size(1) == -1) then
      print *, "ERROR8 array d1001 is not allocated"
    else if((ic001 < 1) .or. (d1001_size(1) < ic001)) then
      print *, "ERROR8 array d1001 illegal access. index ",ic001," is out of range (1:",d1001_size( &
      1),")"
    end if
    !****************************************************
    !***debug array1 access check: 9*****************************
    if(d1002_size(1) == -1) then
      print *, "ERROR9 array d1002 is not allocated"
    else if((ic001 < 1) .or. (d1002_size(1) < ic001)) then
      print *, "ERROR9 array d1002 illegal access. index ",ic001," is out of range (1:",d1002_size( &
      1),")"
    end if
    !****************************************************
    d1003(ic001) = d1001(ic001)+d1002(ic001)
  end do
  !022
  !***debug array1 access check: 10*****************************
  if(3 /= 3) then
    print *, "ERROR10 operator '+' array size mismatch"
  end if
  !****************************************************
  !***debug array1 access check: 11*****************************
  if(3 /= 3) then
    print *, "ERROR11 operator '<==' array size mismatch"
  end if
  !****************************************************
  do ic001=1,3
    !***debug array1 access check: 12*****************************
    if(d1003_size(1) == -1) then
      print *, "ERROR12 array d1003 is not allocated"
    else if((ic001 < 1) .or. (d1003_size(1) < ic001)) then
      print *, "ERROR12 array d1003 illegal access. index ",ic001," is out of range (1:",d1003_size( &
      1),")"
    end if
    !****************************************************
    !***debug array1 access check: 13*****************************
    if(d1001_size(1) == -1) then
      print *, "ERROR13 array d1001 is not allocated"
    else if((ic001+3 < 1) .or. (d1001_size(1) < ic001+3)) then
      print *, "ERROR13 array d1001 illegal access. index ",ic001+3," is out of range (1:", &
      d1001_size(1),")"
    end if
    !****************************************************
    !***debug array1 access check: 14*****************************
    if(d1002_size(1) == -1) then
      print *, "ERROR14 array d1002 is not allocated"
    else if((ic001+3 < 1) .or. (d1002_size(1) < ic001+3)) then
      print *, "ERROR14 array d1002 illegal access. index ",ic001+3," is out of range (1:", &
      d1002_size(1),")"
    end if
    !****************************************************
    d1003(ic001) = d1001(ic001+3)+d1002(ic001+3)
  end do
  !023
  !***debug array1 access check: 15*****************************
  if(d1001_size(1) /= d1002_size(1)) then
    print *, "ERROR15 operator '+' array size mismatch"
  end if
  !****************************************************
  !***debug array1 access check: 16*****************************
  if(d1001_size(1) /= d1001_size(1)) then
    print *, "ERROR16 operator '+' array size mismatch"
  end if
  !****************************************************
  !***debug array1 access check: 17*****************************
  if(d1003_size(1) /= d1001_size(1)) then
    print *, "ERROR17 operator '<==' array size mismatch"
  end if
  !****************************************************
  do ic001=1,d1003_size(1)
    !***debug array1 access check: 18*****************************
    if(d1003_size(1) == -1) then
      print *, "ERROR18 array d1003 is not allocated"
    else if((ic001 < 1) .or. (d1003_size(1) < ic001)) then
      print *, "ERROR18 array d1003 illegal access. index ",ic001," is out of range (1:",d1003_size( &
      1),")"
    end if
    !****************************************************
    !***debug array1 access check: 19*****************************
    if(d1001_size(1) == -1) then
      print *, "ERROR19 array d1001 is not allocated"
    else if((ic001 < 1) .or. (d1001_size(1) < ic001)) then
      print *, "ERROR19 array d1001 illegal access. index ",ic001," is out of range (1:",d1001_size( &
      1),")"
    end if
    !****************************************************
    !***debug array1 access check: 20*****************************
    if(d1001_size(1) == -1) then
      print *, "ERROR20 array d1001 is not allocated"
    else if((ic001 < 1) .or. (d1001_size(1) < ic001)) then
      print *, "ERROR20 array d1001 illegal access. index ",ic001," is out of range (1:",d1001_size( &
      1),")"
    end if
    !****************************************************
    !***debug array1 access check: 21*****************************
    if(d1002_size(1) == -1) then
      print *, "ERROR21 array d1002 is not allocated"
    else if((ic001 < 1) .or. (d1002_size(1) < ic001)) then
      print *, "ERROR21 array d1002 illegal access. index ",ic001," is out of range (1:",d1002_size( &
      1),")"
    end if
    !****************************************************
    d1003(ic001) = d1001(ic001)*(d1001(ic001)+d1002(ic001))
  end do
  !***debug array1 deallocate check: 22*****************************
  if(d1003_size(1) == -1) then
    print *, "ERROR22 cannot deallocate array d1003"
  end if
  !****************************************************
  d1003_size(1) = -1
  deallocate(d1003)
  !***debug array1 allocate check: 23*****************************
  if(d2001_size(1) /= -1) then
    print *, "ERROR23 array d2001 is already allocated"
  end if
  !****************************************************
  d2001_size(1) = 10
  d2001_size(2) = 5
  allocate(d2001(1:d2001_size(1),1:d2001_size(2)))
  !***debug array1 allocate check: 24*****************************
  if(d2002_size(1) /= -1) then
    print *, "ERROR24 array d2002 is already allocated"
  end if
  !****************************************************
  d2002_size(1) = 10
  d2002_size(2) = 5
  allocate(d2002(1:d2002_size(1),1:d2002_size(2)))
  !***debug array1 allocate check: 25*****************************
  if(d2003_size(1) /= -1) then
    print *, "ERROR25 array d2003 is already allocated"
  end if
  !****************************************************
  d2003_size(1) = 10
  d2003_size(2) = 5
  allocate(d2003(1:d2003_size(1),1:d2003_size(2)))
  !024
  !***debug array1 access check: 26*****************************
  if(d2001_size(1) /= d2002_size(1)) then
    print *, "ERROR26 array size1 mismatch"
  end if
  if(d2001_size(2) /= d2002_size(2)) then
    print *, "ERROR26 array size2 mismatch"
  end if
  !****************************************************
  !***debug array1 access check: 27*****************************
  if(d2003_size(1) /= d2001_size(1)) then
    print *, "ERROR27 operator '<==' array size mismatch"
  end if
  if(d2003_size(2) /= d2001_size(2)) then
    print *, "ERROR27 operator '<==' array size mismatch"
  end if
  !****************************************************
  do ic001=1,d2003_size(1)
    do ic002=1,d2003_size(2)
      !***debug array1 access check: 28*****************************
      if((d2003_size(1) == -1) .or. (d2003_size(2) == -1)) then
        print *, "ERROR28 array d2003 is not allocated"
      else if((ic001 < 1) .or. (d2003_size(1) < ic001)) then
        print *, "ERROR28 array d2003 illegal access. index ",ic001," is out of range (1:", &
        d2003_size(1),")"
      else if((ic002 < 1) .or. (d2003_size(2) < ic002)) then
        print *, "ERROR28 array d2003 illegal access. index ",ic002," is out of range (1:", &
        d2003_size(2),")"
      end if
      !****************************************************
      !***debug array1 access check: 29*****************************
      if((d2001_size(1) == -1) .or. (d2001_size(2) == -1)) then
        print *, "ERROR29 array d2001 is not allocated"
      else if((ic001 < 1) .or. (d2001_size(1) < ic001)) then
        print *, "ERROR29 array d2001 illegal access. index ",ic001," is out of range (1:", &
        d2001_size(1),")"
      else if((ic002 < 1) .or. (d2001_size(2) < ic002)) then
        print *, "ERROR29 array d2001 illegal access. index ",ic002," is out of range (1:", &
        d2001_size(2),")"
      end if
      !****************************************************
      !***debug array1 access check: 30*****************************
      if((d2002_size(1) == -1) .or. (d2002_size(2) == -1)) then
        print *, "ERROR30 array d2002 is not allocated"
      else if((ic001 < 1) .or. (d2002_size(1) < ic001)) then
        print *, "ERROR30 array d2002 illegal access. index ",ic001," is out of range (1:", &
        d2002_size(1),")"
      else if((ic002 < 1) .or. (d2002_size(2) < ic002)) then
        print *, "ERROR30 array d2002 illegal access. index ",ic002," is out of range (1:", &
        d2002_size(2),")"
      end if
      !****************************************************
      d2003(ic001,ic002) = d2001(ic001,ic002)+d2002(ic001,ic002)
    end do
  end do
  !025
  !***debug array1 access check: 31*****************************
  if(3 /= 3) then
    print *, "ERROR31 operator '+' array size mismatch"
  end if
  !****************************************************
  !***debug array1 access check: 32*****************************
  if(3 /= 3) then
    print *, "ERROR32 operator '<==' array size mismatch"
  end if
  !****************************************************
  do ic001=1,3
    !***debug array1 access check: 33*****************************
    if((d2003_size(1) == -1) .or. (d2003_size(2) == -1)) then
      print *, "ERROR33 array d2003 is not allocated"
    else if((ic001 < 1) .or. (d2003_size(1) < ic001)) then
      print *, "ERROR33 array d2003 illegal access. index ",ic001," is out of range (1:",d2003_size( &
      1),")"
    else if((3 < 1) .or. (d2003_size(2) < 3)) then
      print *, "ERROR33 array d2003 illegal access. index ",3," is out of range (1:",d2003_size(2),"" &
      //")"
    end if
    !****************************************************
    !***debug array1 access check: 34*****************************
    if((d2001_size(1) == -1) .or. (d2001_size(2) == -1)) then
      print *, "ERROR34 array d2001 is not allocated"
    else if((ic001+3 < 1) .or. (d2001_size(1) < ic001+3)) then
      print *, "ERROR34 array d2001 illegal access. index ",ic001+3," is out of range (1:", &
      d2001_size(1),")"
    else if((3 < 1) .or. (d2001_size(2) < 3)) then
      print *, "ERROR34 array d2001 illegal access. index ",3," is out of range (1:",d2001_size(2),"" &
      //")"
    end if
    !****************************************************
    !***debug array1 access check: 35*****************************
    if((d2002_size(1) == -1) .or. (d2002_size(2) == -1)) then
      print *, "ERROR35 array d2002 is not allocated"
    else if((ic001+3 < 1) .or. (d2002_size(1) < ic001+3)) then
      print *, "ERROR35 array d2002 illegal access. index ",ic001+3," is out of range (1:", &
      d2002_size(1),")"
    else if((3 < 1) .or. (d2002_size(2) < 3)) then
      print *, "ERROR35 array d2002 illegal access. index ",3," is out of range (1:",d2002_size(2),"" &
      //")"
    end if
    !****************************************************
    d2003(ic001,3) = d2001(ic001+3,3)+d2002(ic001+3,3)
  end do
  !026
  !***debug array1 access check: 36*****************************
  if(d2001_size(1) /= d2002_size(1)) then
    print *, "ERROR36 array size1 mismatch"
  end if
  if(d2001_size(2) /= d2002_size(2)) then
    print *, "ERROR36 array size2 mismatch"
  end if
  !****************************************************
  !***debug array1 access check: 37*****************************
  if(d2001_size(1) /= d2001_size(1)) then
    print *, "ERROR37 array size1 mismatch"
  end if
  if(d2001_size(2) /= d2001_size(2)) then
    print *, "ERROR37 array size2 mismatch"
  end if
  !****************************************************
  !***debug array1 access check: 38*****************************
  if(d2003_size(1) /= d2001_size(1)) then
    print *, "ERROR38 operator '<==' array size mismatch"
  end if
  if(d2003_size(2) /= d2001_size(2)) then
    print *, "ERROR38 operator '<==' array size mismatch"
  end if
  !****************************************************
  do ic001=1,d2003_size(1)
    do ic002=1,d2003_size(2)
      !***debug array1 access check: 39*****************************
      if((d2003_size(1) == -1) .or. (d2003_size(2) == -1)) then
        print *, "ERROR39 array d2003 is not allocated"
      else if((ic001 < 1) .or. (d2003_size(1) < ic001)) then
        print *, "ERROR39 array d2003 illegal access. index ",ic001," is out of range (1:", &
        d2003_size(1),")"
      else if((ic002 < 1) .or. (d2003_size(2) < ic002)) then
        print *, "ERROR39 array d2003 illegal access. index ",ic002," is out of range (1:", &
        d2003_size(2),")"
      end if
      !****************************************************
      !***debug array1 access check: 40*****************************
      if((d2001_size(1) == -1) .or. (d2001_size(2) == -1)) then
        print *, "ERROR40 array d2001 is not allocated"
      else if((ic001 < 1) .or. (d2001_size(1) < ic001)) then
        print *, "ERROR40 array d2001 illegal access. index ",ic001," is out of range (1:", &
        d2001_size(1),")"
      else if((ic002 < 1) .or. (d2001_size(2) < ic002)) then
        print *, "ERROR40 array d2001 illegal access. index ",ic002," is out of range (1:", &
        d2001_size(2),")"
      end if
      !****************************************************
      !***debug array1 access check: 41*****************************
      if((d2001_size(1) == -1) .or. (d2001_size(2) == -1)) then
        print *, "ERROR41 array d2001 is not allocated"
      else if((ic001 < 1) .or. (d2001_size(1) < ic001)) then
        print *, "ERROR41 array d2001 illegal access. index ",ic001," is out of range (1:", &
        d2001_size(1),")"
      else if((ic002 < 1) .or. (d2001_size(2) < ic002)) then
        print *, "ERROR41 array d2001 illegal access. index ",ic002," is out of range (1:", &
        d2001_size(2),")"
      end if
      !****************************************************
      !***debug array1 access check: 42*****************************
      if((d2002_size(1) == -1) .or. (d2002_size(2) == -1)) then
        print *, "ERROR42 array d2002 is not allocated"
      else if((ic001 < 1) .or. (d2002_size(1) < ic001)) then
        print *, "ERROR42 array d2002 illegal access. index ",ic001," is out of range (1:", &
        d2002_size(1),")"
      else if((ic002 < 1) .or. (d2002_size(2) < ic002)) then
        print *, "ERROR42 array d2002 illegal access. index ",ic002," is out of range (1:", &
        d2002_size(2),")"
      end if
      !****************************************************
      d2003(ic001,ic002) = d2001(ic001,ic002)*(d2001(ic001,ic002)+d2002(ic001,ic002))
    end do
  end do
  !***debug array1 deallocate check: 43*****************************
  if(d2003_size(1) == -1) then
    print *, "ERROR43 cannot deallocate array d2003"
  end if
  !****************************************************
  !027
  i001 = 1
  !028
  i001 = 1
  i002 = 1
  i002 = 8*i001
  !aaa
  d001 = 2.0d0*dble(i001)
  !bbb
  i002 = 2*i001
  !ccc
  !***debug array1 deallocate check: 44*****************************
  if(d2002_size(1) == -1) then
    print *, "ERROR44 cannot deallocate array d2002"
  end if
  !****************************************************
  !***debug array1 deallocate check: 45*****************************
  if(d2001_size(1) == -1) then
    print *, "ERROR45 cannot deallocate array d2001"
  end if
  !****************************************************
  !***debug array1 deallocate check: 46*****************************
  if(d1002_size(1) == -1) then
    print *, "ERROR46 cannot deallocate array d1002"
  end if
  !****************************************************
  d1002_size(1) = -1
  deallocate(d1002)
  !***debug array1 deallocate check: 47*****************************
  if(d1001_size(1) == -1) then
    print *, "ERROR47 cannot deallocate array d1001"
  end if
  !****************************************************
  d1001_size(1) = -1
  deallocate(d1001)
!%%%end test2%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
!%%%test3%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
  !001
  i001 = 2*i001
  !002
  i001 = 0
  !003
  d001 = 1
  !004
  i001 = 1
  !005
  d001 = 2*(i001+d001)
  !006
  d001 = 4*i001
  !007
  d001 = 0
  !008
  d001 = 0
  !009
  d001 = 1
  !010
  d001 = 1
  !011
  d001 = 1
!%%%end test3%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
!%%%test4%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
  !001
  i001 = -2
  d001 = sin(dble(i001))
  print *, d001
  d001 = cos(dble(i001))
  print *, d001
  d001 = tan(dble(i001))
  print *, d001
  d001 = exp(dble(i001))
  print *, d001
  d001 = log(dble(i001))
  print *, d001
  d001 = log10(dble(i001))
  print *, d001
  d001 = sqrt(dble(i001))
  print *, d001
  d001 = asin(dble(i001))
  print *, d001
  d001 = acos(dble(i001))
  print *, d001
  d001 = atan(dble(i001))
  print *, d001
  d001 = atan2(dble(i001),d001)
  print *, d001
  !002
  d001 = 1.2d0
  d003 = sin(d001)
  print *, d003
  d003 = cos(d001)
  print *, d003
  d003 = tan(d001)
  print *, d003
  d003 = exp(d001)
  print *, d003
  d003 = log(d001)
  print *, d003
  d003 = log10(d001)
  print *, d003
  d003 = sqrt(d001)
  print *, d003
  d003 = asin(d001)
  print *, d003
  d003 = acos(d001)
  print *, d003
  d003 = atan(d001)
  print *, d003
  d003 = atan2(d001,d002)
  print *, d003
  d003 = floor(d001)
  print *, d003
  d003 = ceiling(d001)
  print *, d003
  !003
  z001 = 1.0d0-uj*2.0d0
  z002 = sin(z001)
  print *, real(z002),aimag(z002)
  z002 = cos(z001)
  print *, real(z002),aimag(z002)
  z002 = tan(z001)
  print *, real(z002),aimag(z002)
  z002 = exp(z001)
  print *, real(z002),aimag(z002)
  z002 = log(z001)
  print *, real(z002),aimag(z002)
  z002 = sqrt(z001)
  print *, real(z002),aimag(z002)
  z002 = asin(z001)
  print *, real(z002),aimag(z002)
  z002 = acos(z001)
  print *, real(z002),aimag(z002)
  z002 = atan(z001)
  print *, real(z002),aimag(z002)
!%%%end test4%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

contains

end program test2
