# ideogramChecker.py
# check to see if unicode character code is associated with an ideogram
def isIdeogram( uniChar ):
	# get integers representing Unicode code point of uniChar
	uniCode = [ord(x) for x in unicode(uniChar)]

	# uniCode[0] will remain the same for all mlb characters
	# uniCode[1] will differ (add 1 for each increasing code point)
	# 56448 = first ideogram, 56583 = last ideogram integer value
	if uniCode[1] >= 56448 and uniCode[1] <= 56570:
		return True, uniCode[1]
	return False, 0