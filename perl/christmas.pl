#!/usr/bin/perl
# By Wojtek Jurkowlaniec
use Term::ANSIColor;

my $width = shift || 32;

system("clear");


sub symbol   {
    my $r = rand;
    return '|' if $r < .07;
    return '*' if $r < .18;
    
    '^';
}

for my $cnt (1..$width/2)    {
    print "\n", ' ' x ($width/2 - $cnt);
    for my $x (1..2*$cnt) {
      my $tmp = symbol;
      if ($tmp eq '^' ){
	print color "green ";
      }
      elsif($tmp eq '*'){
	print color "yellow blink";
      }
      elsif($tmp eq '|'){
	print color "blue";
      }
      print $tmp;
      print color 'reset';
    }
    
}

print "\n", ' ' x ($width/2 - 2) . "_||_\n";
print "Wesołych świąt\n";