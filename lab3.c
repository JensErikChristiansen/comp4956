#include <stdio.h>
#include <pthread.h>
#include <unistd.h>
#include <string.h>

int timeout = 0;
int seconds = 0;

void *timerFunc(void *arg) {

	usleep(seconds);

	timeout = 1;
	
	return NULL;
}

/* This is our thread function.  It is like main(), but for a thread */
void *threadFunc(void *arg)
{
	int threadNum = *(int*)arg;
	int i = 0;
	char whitespace[80];

	for (i = 1; i < threadNum; i++) {
		strcat(whitespace, "                ");
	}

	i = 0;
	while (timeout == 0) {
		printf("%sthread %d: %d\n", whitespace, threadNum, i++);
	}

	return NULL;
}

int main(void) {

	int numThreads = 0;
	int i = 0;
	pthread_t workerThread, timerThread;	// this is our thread identifier

	do {
		printf("Enter number of threads (limit 6): ");
		scanf("%d", &numThreads);
	} while (numThreads > 6);

	printf("Enter number of seconds: ");
	scanf("%d", &seconds);

	printf("threads: %d  seconds: %d\n", numThreads, seconds);

	seconds = seconds * 1000000;

	/* Create timer thread */
	pthread_create(&timerThread, NULL, timerFunc, NULL);

	for (i = 0; i < numThreads; i++) {
		pthread_create(&workerThread, NULL, threadFunc, &i);
	}

	/* wait for our thread to finish before continuing */
	pthread_join(timerThread, NULL /* void ** return value could go here */);

	printf("timeout");
	return 0;
	
}
